using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveAppleScript : MonoBehaviour
{
    public static int TodayFood = 1; //�������������̐�
    
    public Text LackAppleText;
    public Text TodayFoodText;
    


    public void OnClickGiveAppleButton()
    {
        if (FoodScript.Apple >= 1)
        {
            if (TodayFood <= 3)
            {
                EvoScript.GiveApple++;
                FoodScript.Apple--;
                TodayFood++;
                EvoScript.GiveApple++;
            }
            else
            {
                TodayFoodText.text = "�����͂����a��^�����܂���";
                StartCoroutine("TextSet");//�R���[�`�������s
            }
        }
        else
        {
            LackAppleText.text = "��񂲂�����܂���";
            StartCoroutine("TextSet");//�R���[�`�������s
        }
    }

    IEnumerator TextSet()
    {
        yield return new WaitForSeconds(1.0f);
        LackAppleText.text = "";
        TodayFoodText.text = "";
    }
}
