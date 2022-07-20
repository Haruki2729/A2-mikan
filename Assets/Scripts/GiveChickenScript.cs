using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveChickenScript : MonoBehaviour
{

    public Text LackChickenText;
    public Text TodayFoodText;


    public void OnClickGiveChickenButton()
    {
        if (FoodScript.Chicken >= 1)
        {
            if (GiveAppleScript.TodayFood <= 3)
            {
                EvoScript.GiveChicken++;
                FoodScript.Chicken--;
                GiveAppleScript.TodayFood++;
                EvoScript.GiveChicken++;
            }
            else
            {
                TodayFoodText.text = "�����͂����a��^�����܂���";
                StartCoroutine("TextSet");//�R���[�`�������s
            }
        }
        else
        {
            LackChickenText.text = "�`�L��������܂���";
            StartCoroutine("TextSet");//�R���[�`�������s
        }
    }

    IEnumerator TextSet()
    {
        yield return new WaitForSeconds(1.0f);
        LackChickenText.text = "";
        TodayFoodText.text = "";
    }
}
