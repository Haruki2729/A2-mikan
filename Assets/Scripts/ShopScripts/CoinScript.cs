using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CoinScript : MonoBehaviour
{
    public Text CoinText;

    //コイン変数
    public static int coin = 1000;

    void Start()
    {

    }

    void Update()
    {
        CoinText.text = coin.ToString();
    }

    public static int returncoin()
    {
        return coin;
    }
}
