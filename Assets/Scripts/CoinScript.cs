using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    public Text CoinText;

    //�R�C���ϐ�
    public int coin;

    void Start()
    {
        //�R�C���̏����l
        coin = 100;
        
    }

    void Update()
    {
        CoinText.text = coin.ToString();
        coin++;
    }
}
