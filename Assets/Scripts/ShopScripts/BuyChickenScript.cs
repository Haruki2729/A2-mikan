using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyChickenScript : MonoBehaviour
{
    //購入成功・失敗用のテキストオブジェクト
    public Text GetText;
    public Text ErrorText;

    public void OnClickChickenYesButton()
    {
        //コインの所持数が金額以上かどうか
        if(CoinScript.coin >= 200){
            FoodScript.Chicken++;//チキン所持数増加
            CoinScript.coin -= 200;//コイン減少
            GetText.text = "チキンを購入しました！";//テキスト表示
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
