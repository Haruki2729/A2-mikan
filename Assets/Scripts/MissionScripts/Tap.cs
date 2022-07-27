using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tap : MonoBehaviour
{

    public static int TapCount = 0;
    //public TextMeshProUGUI ShakeText;
    public Text TapTextL;

    // ボタンが押された場合、今回呼び出される関数
    public void OnClickTapButton()
    {
        TapCount++;
        //TapTextL.text = TapCount.ToString();
        TapTextL.text = TapCount.ToString("000") + "回";
        Debug.Log(TapCount);

        
        if (TapCount == 10)
        {
            TapCount = 0;
            TapTextL.text = ("Clear");
            Debug.Log("Clear");
            SceneManager.LoadScene("MissionClearScene2");
        }
        
    }
}
