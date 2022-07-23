using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Minute10Manager : MonoBehaviour
{
    public static int Minute10 = 0;
    public TextMeshProUGUI ClockText;

    void Start()
    {
        ClockText.text = Minute10.ToString();
    }

    void update(int num)
    {
        Minute10Button(num);
    }

    public void Minute10Button(int num) //�����Ɉ��������Ă������Ƃł��ꂼ��̃{�^�����Ƃ�Unity���ň������w��ł���B
    {
        switch (num)
        {
            case 0: //�����ꂽ�{�^����Unity���Őݒ肳�ꂽ������1�̂������Ƃ�
                Debug.Log("0�̃{�^���������ꂽ��");
                Minute10 = 0;
                ClockText.text = Minute10.ToString();
                GameObject[] objects0 = GameObject.FindGameObjectsWithTag("Minute10");
                foreach (GameObject ball in objects0)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 1:
                Debug.Log("1�̃{�^���������ꂽ��");
                Minute10 = 10;
                ClockText.text = 1.ToString();
                GameObject[] objects1 = GameObject.FindGameObjectsWithTag("Minute10");
                foreach (GameObject ball in objects1)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 2:
                Debug.Log("2�̃{�^���������ꂽ��");
                Minute10 = 20;
                ClockText.text = 2.ToString();
                GameObject[] objects2 = GameObject.FindGameObjectsWithTag("Minute10");
                foreach (GameObject ball in objects2)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 3:
                Debug.Log("3�̃{�^���������ꂽ��");
                Minute10 = 30;
                ClockText.text = 3.ToString();
                GameObject[] objects3 = GameObject.FindGameObjectsWithTag("Minute10");
                foreach (GameObject ball in objects3)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 4:
                Debug.Log("4�̃{�^���������ꂽ��");
                Minute10 = 40;
                ClockText.text = 4.ToString();
                GameObject[] objects4 = GameObject.FindGameObjectsWithTag("Minute10");
                foreach (GameObject ball in objects4)
                {
                    ball.gameObject.SetActive(false);
                }
                break;
            case 5:
                Debug.Log("5�̃{�^���������ꂽ��");
                Minute10 = 50;
                ClockText.text = 5.ToString();
                GameObject[] objects5 = GameObject.FindGameObjectsWithTag("Minute10");
                foreach (GameObject ball in objects5)
                {
                    ball.gameObject.SetActive(false);
                }
                break;

        }
        Debug.Log(Minute10);
    }

    public static int getMinute10()
    {
        return Minute10;
    }
}
