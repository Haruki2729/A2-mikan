using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CoinScript : MonoBehaviour
{
    public Text CoinText;

    //�R�C���ϐ�
    public static int coin = 100;

    void Start()
    {

    }

    void Update()
    {
        CoinText.text = coin.ToString();
    }
}
