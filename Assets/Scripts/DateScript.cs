using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateScript : MonoBehaviour
{
    public Text DateText;

    public static int Foodgauge = 1;//餌ゲージ初期化
    public static int Date = 1;//日数初期化

    public static int todaycoin = 0;//コインを1日1回しか獲得できないようにするための変数

    bool isCalledOnce = false;

    //このスクリプト内だけで使われる変数
    //public static int NowHourTime;
    //public static int NowMinuteTime;
    //public static int NowSecondTime;

    // Start is called before the first frame update
    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {
        //現在時刻を取得
        int NowHourTime = System.DateTime.Now.Hour;
        int NowMinuteTime = System.DateTime.Now.Minute;
        int NowSecondTime = System.DateTime.Now.Second;
        int NowMilliSecondTime = System.DateTime.Now.Millisecond;

        //餌ゲージが0なら日付を1にリセット
        if (Foodgauge == 0){
            Date = 1;
        }

        //一日経ったら日付を進める
        //コイン獲得もリセット
        if(NowHourTime == 0 && NowMinuteTime == 0 && NowSecondTime == 0 && NowMilliSecondTime == 0)
        {
            todaycoin = 0;

            Date++;
          
        }



        //if(System.DateTime.Now.Hour==0 && )

        DateText.text = Date.ToString();
    }
}
