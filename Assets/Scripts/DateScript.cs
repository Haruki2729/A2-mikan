using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateScript : MonoBehaviour
{
    public Text DateText;

    public static int Foodgauge = 0;//餌ゲージ初期化
    public static int Date = 1;//日数初期化

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //餌ゲージが0なら日付を1にリセット
        if (Foodgauge == 0){
            Date = 1;
        }

        DateText.text = Date.ToString();
    }
}
