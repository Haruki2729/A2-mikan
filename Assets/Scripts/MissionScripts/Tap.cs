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

    // �{�^���������ꂽ�ꍇ�A����Ăяo�����֐�
    public void OnClickTapButton()
    {
        TapCount++;
        //TapTextL.text = TapCount.ToString();
        TapTextL.text = TapCount.ToString("000") + "��";
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
