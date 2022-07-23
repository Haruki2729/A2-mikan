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

    public void Hour1Button(int num) //ここに引数を入れておくことでそれぞれのボタンごとにUnity側で引数を指定できる。
    {
        switch (num)
        {
            case 0: //押されたボタンのUnity側で設定された引数が1のだったとき
                Debug.Log("0のボタンが押されたよ");
                Hour1 = 0;
                ClockText.text = Hour1.ToString();
                GameObject[] objects0 = GameObject.FindGameObjectsWithTag("Hour1");
                foreach (GameObject ball in objects0)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 1:
                Debug.Log("1のボタンが押されたよ");
                Hour1 = 1;
                ClockText.text = Hour1.ToString();
                GameObject[] objects1 = GameObject.FindGameObjectsWithTag("Hour1");
                foreach (GameObject ball in objects1)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 2:
                Debug.Log("2のボタンが押されたよ");
                Hour1 = 2;
                ClockText.text = Hour1.ToString();
                GameObject[] objects2 = GameObject.FindGameObjectsWithTag("Hour1");
                foreach (GameObject ball in objects2)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 3:
                Debug.Log("3のボタンが押されたよ");
                Hour1 = 3;
                ClockText.text = Hour1.ToString();
                GameObject[] objects3 = GameObject.FindGameObjectsWithTag("Hour1");
                foreach (GameObject ball in objects3)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 4:
                Debug.Log("4のボタンが押されたよ");
                Hour1 = 4;
                ClockText.text = Hour1.ToString();
                GameObject[] objects4 = GameObject.FindGameObjectsWithTag("Hour1");
                foreach (GameObject ball in objects4)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 5:
                Debug.Log("5のボタンが押されたよ");
                Hour1 = 5;
                ClockText.text = Hour1.ToString();
                GameObject[] objects5 = GameObject.FindGameObjectsWithTag("Hour1");
                foreach (GameObject ball in objects5)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 6:
                Debug.Log("6のボタンが押されたよ");
                Hour1 = 6;
                ClockText.text = Hour1.ToString();
                GameObject[] objects6 = GameObject.FindGameObjectsWithTag("Hour1");
                foreach (GameObject ball in objects6)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 7:
                Debug.Log("7のボタンが押されたよ");
                Hour1 = 7;
                ClockText.text = Hour1.ToString();
                GameObject[] objects7 = GameObject.FindGameObjectsWithTag("Hour1");
                foreach (GameObject ball in objects7)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 8:
                Debug.Log("8のボタンが押されたよ");
                Hour1 = 8;
                ClockText.text = Hour1.ToString();
                GameObject[] objects8 = GameObject.FindGameObjectsWithTag("Hour1");
                foreach (GameObject ball in objects8)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 9:
                Debug.Log("9のボタンが押されたよ");
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