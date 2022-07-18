using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyCakeScript : MonoBehaviour
{
    //購入成功・失敗用のテキストオブジェクト
    public Text GetText;
    public Text ErrorText;

    public void OnClickCakeYesButton()
    {
        //コインの所持数が金額以上かどうか
        if(CoinScript.coin >= 1000){
            FoodScript.Cake++;//チキン所持数増加
            CoinScript.coin -= 1000;//コイン減少
            GetText.text = "ケーキを購入しました！";//テキスト表示
            StartCoroutine("TextSet");//コルーチンを実行
        }
        else
        {
            ErrorText.text = "コインが足りません";//テキスト表示
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
