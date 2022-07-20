using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidNativeManager : MonoBehaviour
{

    AndroidJavaClass unityClass;
    AndroidJavaObject unityActivity;
    AndroidJavaObject pluginInstance;

    PluginCallback pluginCallback;

    string[] ItemList = new string[] {"Apple", "Mango", "Orange", "Grapes"};

    // Start is called before the first frame update
    void Start()
    {
        InitializePlugins("com.example.native_plugin.NativeAndroidPlugin");
        pluginCallback = new PluginCallback();
        pluginCallback.manager = this;
        SetPluginCallback(pluginCallback);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitializePlugins(string pluginName)
    {
        unityClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        unityActivity = unityClass.GetStatic<AndroidJavaObject>("currentActivity");
        pluginInstance = new AndroidJavaObject(pluginName);
        if (pluginInstance == null)
        {
            Debug.Log("Plugin Instance Null!!");
            return;
        }
        pluginInstance.CallStatic("receiveUnityActivity", unityActivity);
    }
    void SetPluginCallback(PluginCallback callback)
    {
        pluginInstance.Call("SetPluginCallback", callback);
    }

    public void OnClickSingleList()
    {
        pluginInstance.Call("ShowSingleItemList", "Pick your choice", true, ItemList, "Done", "Cancel");
    }

    public void GetSingleItem(int idx)
    {
        Debug.Log("Selected from single list: " + ItemList[idx]);
    }

    public void OnClickMultiItem()
    {
        pluginInstance.Call("ShowMultiItemsList", "Pick your choice", true, ItemList, "Done", "Cancel");
    }

    public void GetMultipleItems(bool[] _checked)
    {
        Debug.Log("Selected multi items: ");
        for (int i = 0; i < _checked.Length; i++)
        {
            if (_checked[i])
            {
                Debug.Log(ItemList[i]);
            }
        }
    }

    public void OnClick3BAlert()
    {
        pluginInstance.Call("Create3BtnAlert", "Do you accept?", true, "Yes", "No", "Not Now");
    }

    public void PickDate()
    {
        pluginInstance.Call("PickDate");
    }

    public void PickTime()
    {
        pluginInstance.Call("PickTime");
    }

}
class PluginCallback : AndroidJavaProxy
{
    public PluginCallback() : base("com.example.native_plugin.PluginCallback") { }

    public AndroidNativeManager manager;

    public void ClickedAlert(int type)
    {
        if (type == 0)
        {
            Debug.Log("Alert: Yes");
        } else if (type == 1)
        {
            Debug.Log("Alert: No");
        } else if (type == 2)
        {
            Debug.Log("Alert: Neutral");
        }
    }
    public void UpdateSingleItem(int idx)
    {
        manager.GetSingleItem(idx);
    }
    public void UpdateMultiItemList(bool[] _checked)
    {
        manager.GetMultipleItems(_checked);
    }

    public void OnDatePicked(int year, int month, int day)
    {
        Debug.Log("Date picked: " + year + "/" + (month+1) + "/" + day);
    }
    public void OnTimePicked(int hour, int mins)
    {
        Debug.Log("Time picked: " + hour + ":" + mins);
    }

}