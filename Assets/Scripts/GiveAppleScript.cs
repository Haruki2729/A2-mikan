using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GiveAppleScript : MonoBehaviour
{
    public static int TodayFood = 1; //今日あげた分の数
    public static int limit = 3; //1日にあげられる餌の最大量

    public Text GiveText;
    public Text CantText;
    public Text LackText;
    public TextMeshProUGUI EatAppleText;

    public void OnClickGiveAppleButton()
    {
        if (FoodScript.Apple >= 1)
        {
            if (TodayFood <= limit)
            {
                
                GiveText.text = "りんごをあげたよ";
                StartCoroutine("TextSet");//コルーチンを実行

                /*GameObject[] objects = GameObject.FindGameObjectsWithTag("GiveApple");
                //りんごを与えた場合のポップアップを表示
                foreach (GameObject ball in objects1)
                {
                    ball.gameObject.SetActive(true);
                }*/
                

                EvoScript.GiveApple++;
                FoodScript.Apple--;
                TodayFood++;
                EatAppleText.text = EvoScript.GiveApple.ToString();
            }
            else
            {
                /*GameObject[] objects = GameObject.FindGameObjectsWithTag("CantToday");
                //３回以上与えようとした場合のポップアップを表示
                foreach (GameObject ball in objects)
                {
                    ball.gameObject.SetActive(true);
                }
                */
                CantText.text = "今日はもう餌をあげられないよ";
                StartCoroutine("TextSet");//コルーチンを実行

            }
        }
        else
        {
            /* GameObject[] objects = GameObject.FindGameObjectsWithTag("LackApple");

             //りんごが不足している場合のポップアップを表示
             foreach (GameObject ball in objects)
             {
                 ball.gameObject.SetActive(true);
             }*/

            LackText.text = "りんごが足りないよ";
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
