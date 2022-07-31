using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EvoScript : MonoBehaviour
{
    public static int GiveApple = 0;
    public static int GiveChicken = 0;
    public static int GiveFish = 0;
    public static int GiveCake = 0;

    public static int No1 = 0;
    public static int No2 = 0;
    public static int No3 = 0;
    public static int No4 = 0;
    public static int No5 = 0;
    public static int No6 = 0;
    public static int No7 = 0;
    public static int No8 = 0;
    public static int No9 = 0;
    public static int No10 = 0;
    public static int No11 = 0;
    public static int No12 = 0;

    public int i;
    public static int HomeNumber = 0;
    public static int NewHomeNumber;


    // Start is called before the first frame update
    void Start()
    {
        i = Random.Range(1, 4);
    }

    // Update is called once per frame
    void Update()
    {
        if (GiveApple + GiveCake + GiveChicken + GiveFish == 2)
        {
            //ケーキ
            if (GiveCake >= GiveApple && GiveCake >= GiveChicken && GiveCake >= GiveFish)
            {
                NewHomeNumber = 9 + i;
                //進化先が進化元と重複した場合の処理
                if (NewHomeNumber == HomeNumber)
                {
                    switch (i)
                    {
                        case 1:
                            i = Random.Range(2, 4);
                            break;
                        case 2:
                            i = Random.Range(1, 3);
                            if (i == 2)
                            {
                                i++;
                            }
                            break;
                        case 3:
                            i = Random.Range(1, 3);
                            break;
                    }
                }
                SceneManager.LoadScene("EvoScene" + (9 + i));
                HomeNumber = 9 + i;
                GiveCake = 0;
                GiveApple = 0;
                GiveChicken = 0;
                GiveFish = 0;
            }

            //魚
            else if (GiveFish >= GiveChicken && GiveFish >= GiveApple)
            {
                NewHomeNumber = 6 + i;
                //進化先が進化元と重複した場合の処理
                if (NewHomeNumber == HomeNumber)
                {
                    switch (i)
                    {
                        case 1:
                            i = Random.Range(2, 4);
                            break;
                        case 2:
                            i = Random.Range(1, 3);
                            if (i == 2)
                            {
                                i++;
                            }
                            break;
                        case 3:
                            i = Random.Range(1, 3);
                            break;
                    }
                }
                SceneManager.LoadScene("EvoScene" + (6 + i));
                HomeNumber = 6 + i;
                GiveCake = 0;
                GiveApple = 0;
                GiveChicken = 0;
                GiveFish = 0;
            }

            //チキン
            else if (GiveChicken >= GiveApple)
            {
                NewHomeNumber = 3 + i;
                //進化先が進化元と重複した場合の処理
                if (NewHomeNumber == HomeNumber)
                {
                    switch (i)
                    {
                        case 1:
                            i = Random.Range(2, 4);
                            break;
                        case 2:
                            i = Random.Range(1, 3);
                            if (i == 2)
                            {
                                i++;
                            }
                            break;
                        case 3:
                            i = Random.Range(1, 3);
                            break;
                    }
                }
                SceneManager.LoadScene("EvoScene" + (3 + i));
                HomeNumber = 3 + i;
                GiveCake = 0;
                GiveApple = 0;
                GiveChicken = 0;
                GiveFish = 0;
            }

            //リンゴ
            else
            {
                NewHomeNumber = i;
                //進化先が進化元と重複した場合の処理
                if (NewHomeNumber == HomeNumber)
                {
                    switch (i)
                    {
                        case 1:
                            i = Random.Range(2, 4);
                            break;
                        case 2:
                            i = Random.Range(1, 3);
                            if (i == 2)
                            {
                                i++;
                            }
                            break;
                        case 3:
                            i = Random.Range(1, 3);
                            break;
                    }
                }
                SceneManager.LoadScene("EvoScene" + i);
                HomeNumber = i;
                GiveCake = 0;
                GiveApple = 0;
                GiveChicken = 0;
                GiveFish = 0;
            }
        }

        //図鑑開放のための処理
        switch (HomeNumber)
        {
            case 1:
                No1 = 1;
                break;
            case 2:
                No2 = 1;
                break;
            case 3:
                No3 = 1;
                break;
            case 4:
                No4 = 1;
                break;
            case 5:
                No5 = 1;
                break;
            case 6:
                No6 = 1;
                break;
            case 7:
                No7 = 1;
                break;
            case 8:
                No8 = 1;
                break;
            case 9:
                No9 = 1;
                break;
            case 10:
                No10 = 1;
                break;
            case 11:
                No11 = 1;
                break;
            case 12:
                No12 = 1;
                break;
        }
    }

    public static int returnGiveApple()
    {
        return GiveApple;
    }

    public static int returnGiveChicken()
    {
        return GiveChicken;
    }

    public static int returnGiveFish()
    {
        return GiveFish;
    }

    public static int returnGiveCake()
    {
        return GiveCake;
    }
}