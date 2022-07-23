using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HourManager : MonoBehaviour
{
    public static int SetHour = 0;
    public TextMeshProUGUI ClockText;

    void Start()
    {
        ClockText.text = SetHour.ToString("時");
    }

    void update()
    {
        HourOKButton();
    }

    public void HourOKButton() //ここに引数を入れておくことでそれぞれのボタンごとにUnity側で引数を指定できる。
    {
        int Hour10 = Hour10Manager.getHour10();
        int Hour1 = Hour1Manager.getHour1();
        SetHour = Hour10 + Hour1;
        GameObject[] objects = GameObject.FindGameObjectsWithTag("HourOK");
        foreach (GameObject ball in objects)
        {
            ball.gameObject.SetActive(false);
        }
        Debug.Log("SetHour = " + SetHour);
        ClockText.text = SetHour.ToString("00");
    }

    public static int getSetHour()
    {
        return SetHour;
    }

}