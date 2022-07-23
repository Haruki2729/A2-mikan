using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MinuteManager : MonoBehaviour
{
    public static int SetMinute = 0;
    public TextMeshProUGUI ClockText;

    void Start()
    {
        ClockText.text = SetMinute.ToString("��");
    }

    void update()
    {
        MinuteOKButton();
    }

    public void MinuteOKButton() //�����Ɉ��������Ă������Ƃł��ꂼ��̃{�^�����Ƃ�Unity���ň������w��ł���B
    {
        int Minute10 = Minute10Manager.getMinute10();
        int Minute1 = Minute1Manager.getMinute1();
        SetMinute = Minute10 + Minute1;
        GameObject[] objects = GameObject.FindGameObjectsWithTag("MinuteOK");
        foreach (GameObject ball in objects)
        {
            ball.gameObject.SetActive(false);
        }
        Debug.Log("SetMinute = " + SetMinute);
        ClockText.text = SetMinute.ToString("00");
    }

    public static int getSetMinute()
    {
        return SetMinute;
    }

}