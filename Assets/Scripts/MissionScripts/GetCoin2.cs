using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetCoin2 : MonoBehaviour
{
    public TextMeshProUGUI CoinText;
    public static int CoinMaisu;

    void Start()
    {
        CoinMaisu = TimeLimit2.seconds * 50;
        CoinScript.coin += CoinMaisu;
    }

    void Update()
    {
        CoinText.text = CoinMaisu.ToString();
    }
}
