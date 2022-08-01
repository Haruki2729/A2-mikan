using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GiveCakeScript : MonoBehaviour
{

    public Text GiveText;
    public Text CantText;
    public Text LackText;

    public TextMeshProUGUI EatCakeText;

    public void OnClickGiveCakeButton()
    {
        if (FoodScript.Cake >= 1)
        {
            if (GiveAppleScript.TodayFood <= GiveAppleScript.limit)
            {
                GiveText.text = "ケーキをあげたよ！";

                EvoScript.GiveCake++;
                FoodScript.Cake--;
                GiveAppleScript.TodayFood++;
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
