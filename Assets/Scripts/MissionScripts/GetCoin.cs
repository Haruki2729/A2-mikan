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
        CoinMaisu = TimeLimit.seconds * 50;
        CoinScript.coin += CoinMaisu;
    }

    void Update()
    {
        CoinText.text = CoinMaisu.ToString();
    }
}
