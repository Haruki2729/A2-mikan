using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveCakeScript : MonoBehaviour
{

    public Text GiveText;
    public Text CantText;
    public Text LackText;


    public void OnClickGiveCakeButton()
    {
        if (FoodScript.Cake >= 1)
        {
            if (GiveAppleScript.TodayFood <= 3)
            {
                GiveText.text = "�P�[�L����������I";

                EvoScript.GiveCake++;
                FoodScript.Cake--;
                GiveAppleScript.TodayFood++;
                EvoScript.GiveCake++;
            }
            else
            {
                CantText.text = "�����͂����a��^�����Ȃ���";
                StartCoroutine("TextSet");//�R���[�`�������s
            }
        }
        else
        {
            LackText.text = "�P�[�L������Ȃ���";
            StartCoroutine("TextSet");//�R���[�`�������s
        }
    }

    IEnumerator TextSet()
    {
        yield return new WaitForSeconds(1.0f);
        GiveText.text = "";
        CantText.text = "";
        LackText.text = "";
    }
}
