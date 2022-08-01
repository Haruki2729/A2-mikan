using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GiveFishScript : MonoBehaviour
{

    public Text GiveText;
    public Text CantText;
    public Text LackText;

    public TextMeshProUGUI EatFishText;

    public void OnClickGiveFishButton()
    {
        if (FoodScript.Fish >= 1)
        {
            if (GiveAppleScript.TodayFood <= GiveAppleScript.limit)
            {
                GiveText.text = "おさかなをあげたよ！";
                StartCoroutine("TextSet");//コルーチンを実行

                EvoScript.GiveFish++;
                FoodScript.Fish--;
                GiveAppleScript.TodayFood++;
                EatFishText.text = EvoScript.GiveFish.ToString();
            }
            else
            {
                CantText.text = "今日はもう餌を与えられないよ";
                StartCoroutine("TextSet");//コルーチンを実行
            }
        }
        else
        {
            LackText.text = "おさかなが足りないよ";
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
