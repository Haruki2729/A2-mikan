using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveAppleScript : MonoBehaviour
{
    public static int TodayFood = 1; //�������������̐�

    public Text GiveText;
    public Text CantText;
    public Text LackText;


    public void OnClickGiveAppleButton()
    {
        if (FoodScript.Apple >= 1)
        {
            if (TodayFood <= 3)
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
