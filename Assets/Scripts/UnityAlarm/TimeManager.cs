using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeManager : MonoBehaviour
{

    public static int SetTime;
    private string SetTimestr;
    private string Hourstr;
    private string Minutestr;
    public static int TimeNow;
    private string TimeNowstr;
    private string zero = ("0");

    void update()
    {
        TimeJudge();
    }

    public void TimeJudge()
    {
        int Hour = HourManager.getSetHour();
        int Minute = MinuteManager.getSetMinute();

        if (Minute <= 9)
        {
            Hour = Hour * 10;
        }

        Hourstr = Hour.ToString();
        Minutestr = Minute.ToString();


        SetTimestr = Hourstr + Minutestr + zero + zero;


        SetTime = Int32.Parse(SetTimestr);

        Debug.Log("SetTimeInt = " + SetTime);

        /*
        TimeNow = GetTime.getTimeNow();

        TimeNowstr = TimeNow.ToString();
        */
        /*
        if (SetTimestr.Equals(TimeNowstr))
        {
            Debug.Log("‚·‚²‚¢III");
        }
        */


    }

    public static int getSetTime()
    {
        return SetTime;
    }



}
