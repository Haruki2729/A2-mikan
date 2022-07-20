using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveFishScript : MonoBehaviour
{

    public Text LackFishText;
    public Text TodayFoodText;


    public void OnClickGiveFishButton()
    {
        if (FoodScript.Fish >= 1)
        {
            if (GiveAppleScript.TodayFood <= 3)
            {
                EvoScript.GiveFish++;
                FoodScript.Fish--;
                GiveAppleScript.TodayFood++;
                EvoScript.GiveFish++;
            }
            else
            {
                TodayFoodText.text = "今日はもう餌を与えられません";
                StartCoroutine("TextSet");//コルーチンを実行
            }
        }
        else
        {
            LackFishText.text = "おさかなが足りません";
            StartCoroutine("TextSet");//コルーチンを実行
        }
    }

    IEnumerator TextSet()
    {
        yield return new WaitForSeconds(1.0f);
        LackFishText.text = "";
        TodayFoodText.text = "";
    }
}
