using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hour10Manager : MonoBehaviour
{
    public static int Hour10 = 0;
    public TextMeshProUGUI ClockText;

    void Start()
    {
        ClockText.text = Hour10.ToString();
    }

    void update(int num)
    {
        Hour10Button(num);
    }

    public void Hour10Button(int num) //ここに引数を入れておくことでそれぞれのボタンごとにUnity側で引数を指定できる。
    {
        switch (num)
        {
            case 0: //押されたボタンのUnity側で設定された引数が1のだったとき
                Debug.Log("0のボタンが押されたよ");
                Hour10 = 0;
                ClockText.text = Hour10.ToString();
                GameObject[] objects0 = GameObject.FindGameObjectsWithTag("Hour10");
                foreach (GameObject ball in objects0)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 1:
                Debug.Log("1のボタンが押されたよ");
                Hour10 = 10;
                ClockText.text = 1.ToString();
                GameObject[] objects1 = GameObject.FindGameObjectsWithTag("Hour10");
                foreach (GameObject ball in objects1)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 2:
                Debug.Log("2のボタンが押されたよ");
                Hour10 = 20;
                ClockText.text = 2.ToString();
                GameObject[] objects2 = GameObject.FindGameObjectsWithTag("Hour10");
                foreach (GameObject ball in objects2)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            
        }
        Debug.Log(Hour10);
    }

    public static int getHour10()
    {
        return Hour10;
    }
}