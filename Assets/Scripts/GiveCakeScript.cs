using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveCakeScript : MonoBehaviour
{

    public Text LackCakeText;
    public Text TodayFoodText;


    public void OnClickGiveCakeButton()
    {
        if (FoodScript.Cake >= 1)
        {
            if (GiveAppleScript.TodayFood <= 3)
            {
                EvoScript.GiveCake++;
                FoodScript.Cake--;
                GiveAppleScript.TodayFood++;
                EvoScript.GiveCake++;
            }
            else
            {
                TodayFoodText.text = "�����͂����a��^�����܂���";
                StartCoroutine("TextSet");//�R���[�`�������s
            }
        }
        else
        {
            LackCakeText.text = "�P�[�L������܂���";
            StartCoroutine("TextSet");//�R���[�`�������s
        }
    }

    IEnumerator TextSet()
    {
        yield return new WaitForSeconds(1.0f);
        LackCakeText.text = "";
        TodayFoodText.text = "";
    }
}
