using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GiveAppleScript : MonoBehaviour
{
    public static int TodayFood = 1; //�������������̐�
    public static int limit = 3; //1���ɂ�������a�̍ő��

    public Text GiveText;
    public Text CantText;
    public Text LackText;
    public TextMeshProUGUI EatAppleText;

    public void OnClickGiveAppleButton()
    {
        if (FoodScript.Apple >= 1)
        {
            if (TodayFood <= limit)
            {
                
                GiveText.text = "��񂲂���������";
                StartCoroutine("TextSet");//�R���[�`�������s

                /*GameObject[] objects = GameObject.FindGameObjectsWithTag("GiveApple");
                //��񂲂�^�����ꍇ�̃|�b�v�A�b�v��\��
                foreach (GameObject ball in objects1)
                {
                    ball.gameObject.SetActive(true);
                }*/
                

                EvoScript.GiveApple++;
                FoodScript.Apple--;
                TodayFood++;
                EatAppleText.text = EvoScript.GiveApple.ToString();
            }
            else
            {
                /*GameObject[] objects = GameObject.FindGameObjectsWithTag("CantToday");
                //�R��ȏ�^���悤�Ƃ����ꍇ�̃|�b�v�A�b�v��\��
                foreach (GameObject ball in objects)
                {
                    ball.gameObject.SetActive(true);
                }
                */
                CantText.text = "�����͂����a���������Ȃ���";
                StartCoroutine("TextSet");//�R���[�`�������s

            }
        }
        else
        {
            /* GameObject[] objects = GameObject.FindGameObjectsWithTag("LackApple");

             //��񂲂��s�����Ă���ꍇ�̃|�b�v�A�b�v��\��
             foreach (GameObject ball in objects)
             {
                 ball.gameObject.SetActive(true);
             }*/

            LackText.text = "��񂲂�����Ȃ���";
            StartCoroutine("TextSet");//�R���[�`�������s
        }
    }

    IEnumerator TextSet()
    {
        yield return new WaitForSeconds(1.0f);
        GiveText.text = "";
        CantText.text = "";
        LackText.text = "";
    }

}
