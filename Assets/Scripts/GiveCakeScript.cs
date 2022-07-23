using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveCakeScript : MonoBehaviour
{

    public Text GiveText;
    public Text CantText;
    public Text LackText;


    public void OnClickGiveCakeButton()
    {
        if (FoodScript.Cake >= 1)
        {
            if (GiveAppleScript.TodayFood <= 3)
            {
                GiveText.text = "ケーキをあげたよ！";

                EvoScript.GiveCake++;
                FoodScript.Cake--;
                GiveAppleScript.TodayFood++;
                EvoScript.GiveCake++;
            }
            else
            {
                CantText.text = "今日はもう餌を与えられないよ";
                StartCoroutine("TextSet");//コルーチンを実行
            }
        }
        else
        {
            LackText.text = "ケーキが足りないよ";
            StartCoroutine("TextSet");//コルーチンを実行
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
