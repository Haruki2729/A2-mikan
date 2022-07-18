using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CoinScript : MonoBehaviour
{
    public Text CoinText;

    //ƒRƒCƒ“•Ï”
    public static int coin = 10000;

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
