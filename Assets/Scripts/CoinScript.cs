using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    public Text CoinText;

    //コイン変数
    public int coin;

    void Start()
    {
        //コインの初期値
        coin = 100;
        
    }

    void Update()
    {
        CoinText.text = coin.ToString();
        coin++;
    }
}
