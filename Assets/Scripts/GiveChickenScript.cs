using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveChickenScript : MonoBehaviour
{

    public Text GiveText;
    public Text CantText;
    public Text LackText;


    public void OnClickGiveChickenButton()
    {
        if (FoodScript.Chicken >= 1)
        {
            if (GiveAppleScript.TodayFood <= 3)
            {

                GiveText.text = "チキンをあげたよ";
                StartCoroutine("TextSet");//コルーチンを実行

                EvoScript.GiveChicken++;
                FoodScript.Chicken--;
                GiveAppleScript.TodayFood++;
                EvoScript.GiveChicken++;
            }
            else
            {
                CantText.text = "今日はもう餌をあげられないよ";
                StartCoroutine("TextSet");//コルーチンを実行

            }
        }
        else
        {

            LackText.text = "チキンが足りないよ";
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
