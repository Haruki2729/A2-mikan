using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyAppleScript : MonoBehaviour
{
    public Text GetText;
    public Text ErrorText;

    public int test = 100;

    public void OnClickAppleYesButton()
    {
        if(test >= 100){
            //Debug.Log(FoodScript.Apple);
            //Apple++;
            //coin -= 100;
            GetText.text = "りんごを購入しました！";
            StartCoroutine("TextSet");//コルーチンを実行
        }
        else
        {
            ErrorText.text = "コインが足りません";
            StartCoroutine("TextSet");//コルーチンを実行
        }
    }

    IEnumerator TextSet()
    {
        yield return new WaitForSeconds(1.0f);
        GetText.text = "";
        ErrorText.text = "";
    }

}
