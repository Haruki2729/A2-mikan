using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveAppleScript : MonoBehaviour
{
    public static int TodayFood = 1; //今日あげた分の数
    
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
                TodayFoodText.text = "今日はもう餌を与えられません";
                StartCoroutine("TextSet");//コルーチンを実行
            }
        }
        else
        {
            LackAppleText.text = "りんごが足りません";
            StartCoroutine("TextSet");//コルーチンを実行
        }
    }

    IEnumerator TextSet()
    {
        yield return new WaitForSeconds(1.0f);
        LackAppleText.text = "";
        TodayFoodText.text = "";
    }
}
