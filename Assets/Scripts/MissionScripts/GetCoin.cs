using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetCoin : MonoBehaviour
{
    public TextMeshProUGUI CoinText;
    public static int CoinMaisu;

    void Start()
    {
        if(DateScript.todaycoin == 0)
        {
            CoinMaisu = TimeLimit.seconds * 50;
            DateScript.todaycoin = 1;
        }
        else
        {
            CoinMaisu = 0;
        }
        CoinScript.coin += CoinMaisu;
    }

    void Update()
    {
        CoinText.text = CoinMaisu.ToString();
    }
}
