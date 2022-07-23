using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GetTime : MonoBehaviour
{

    public TextMeshProUGUI ClockText;
    public string HourNowstr;
    public string MinuteNowstr;
    public string SecondNowstr;
    public string TimeNowstr;
    public static string SetTimestr;
    public static int SetTimeInt = 0;
    public static int TimeNowInt;
    public static int SecondNowInt;


    // Use this for initialization
    void Start()
    {
        ClockText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        ClockText.text = DateTime.Now.ToLongTimeString();
        //Debug.Log("åªç›éû = " + DateTime.Now.Hour.ToString());

        
        //SecondNow = DateTime.Now.Second();
        //Debug.Log("SecondNow = " + SecondNow);
        // éÊìæÇ∑ÇÈíl: ïb
        HourNowstr = System.DateTime.Now.Hour.ToString();
        //Debug.Log("HourNowstr = " + HourNowstr);

        MinuteNowstr = System.DateTime.Now.Minute.ToString();
        MinuteNowstr = MinuteNowstr.PadLeft(2, '0');
        //Debug.Log("MinuteNowstr = " + MinuteNowstr);

        SecondNowstr = System.DateTime.Now.Second.ToString();
        SecondNowstr = SecondNowstr.PadLeft(2, '0');
        //Debug.Log("SecondNowstr = " + SecondNowstr);

        

        TimeNowstr = HourNowstr + MinuteNowstr + SecondNowstr;
        Debug.Log("TimeNowstr = " + TimeNowstr);

        TimeNowInt = Int32.Parse(TimeNowstr);
        SecondNowInt = Int32.Parse(SecondNowstr);

        if (SecondNowInt == 0)
        {
            ArarmCheck(TimeNowInt);
        }
        

    }

    
    public static int getTimeNow()
    {
        return TimeNowInt;
    }

    public static int getTimeSecondNow()
    {
        return System.DateTime.Now.Second;
    }

    public void ArarmCheck(int TimeNowInt)
    {
        int SetTimeInt = TimeManager.getSetTime();

        if (SetTimeInt <= TimeNowInt)
        {
            Debug.Log("ê›íËéûä‘Ç…Ç»Ç¡ÇΩÇÊ");
            // GetComponent<AudioSource>().Play();
            SceneManager.LoadScene("UnityAlarmScene2");
        }
    }
    

}