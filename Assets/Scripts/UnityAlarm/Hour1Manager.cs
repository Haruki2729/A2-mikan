using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hour1Manager : MonoBehaviour
{
    public static int Hour1 = 0;
    public TextMeshProUGUI ClockText;

    void Start()
    {
        ClockText.text = Hour1.ToString();
    }
    
    void update(int num)
    {
        Hour1Button(num);
    }

    public void Hour1Button(int num) //�����Ɉ��������Ă������Ƃł��ꂼ��̃{�^�����Ƃ�Unity���ň������w��ł���B
    {
        switch (num)
        {
            case 0: //�����ꂽ�{�^����Unity���Őݒ肳�ꂽ������1�̂������Ƃ�
                Debug.Log("0�̃{�^���������ꂽ��");
                Hour1 = 0;
                ClockText.text = Hour1.ToString();
                GameObject[] objects0 = GameObject.FindGameObjectsWithTag("Hour1");
                foreach (GameObject ball in objects0)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 1:
                Debug.Log("1�̃{�^���������ꂽ��");
                Hour1 = 1;
                ClockText.text = Hour1.ToString();
                GameObject[] objects1 = GameObject.FindGameObjectsWithTag("Hour1");
                foreach (GameObject ball in objects1)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 2:
                Debug.Log("2�̃{�^���������ꂽ��");
                Hour1 = 2;
                ClockText.text = Hour1.ToString();
                GameObject[] objects2 = GameObject.FindGameObjectsWithTag("Hour1");
                foreach (GameObject ball in objects2)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 3:
                Debug.Log("3�̃{�^���������ꂽ��");
                Hour1 = 3;
                ClockText.text = Hour1.ToString();
                GameObject[] objects3 = GameObject.FindGameObjectsWithTag("Hour1");
                foreach (GameObject ball in objects3)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 4:
                Debug.Log("4�̃{�^���������ꂽ��");
                Hour1 = 4;
                ClockText.text = Hour1.ToString();
                GameObject[] objects4 = GameObject.FindGameObjectsWithTag("Hour1");
                foreach (GameObject ball in objects4)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 5:
                Debug.Log("5�̃{�^���������ꂽ��");
                Hour1 = 5;
                ClockText.text = Hour1.ToString();
                GameObject[] objects5 = GameObject.FindGameObjectsWithTag("Hour1");
                foreach (GameObject ball in objects5)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 6:
                Debug.Log("6�̃{�^���������ꂽ��");
                Hour1 = 6;
                ClockText.text = Hour1.ToString();
                GameObject[] objects6 = GameObject.FindGameObjectsWithTag("Hour1");
                foreach (GameObject ball in objects6)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 7:
                Debug.Log("7�̃{�^���������ꂽ��");
                Hour1 = 7;
                ClockText.text = Hour1.ToString();
                GameObject[] objects7 = GameObject.FindGameObjectsWithTag("Hour1");
                foreach (GameObject ball in objects7)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 8:
                Debug.Log("8�̃{�^���������ꂽ��");
                Hour1 = 8;
                ClockText.text = Hour1.ToString();
                GameObject[] objects8 = GameObject.FindGameObjectsWithTag("Hour1");
                foreach (GameObject ball in objects8)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 9:
                Debug.Log("9�̃{�^���������ꂽ��");
                Hour1 = 9;
                ClockText.text = Hour1.ToString();
                GameObject[] objects9 = GameObject.FindGameObjectsWithTag("Hour1");
                foreach (GameObject ball in objects9)
                {
                    ball.gameObject.SetActive(false);
                }
                break;

        }
        Debug.Log(Hour1);
    }

    public static int getHour1()
    {
        return Hour1;
    }
}