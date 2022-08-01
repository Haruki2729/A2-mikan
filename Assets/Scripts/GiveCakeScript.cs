using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GiveCakeScript : MonoBehaviour
{

    public Text GiveText;
    public Text CantText;
    public Text LackText;

    public TextMeshProUGUI EatCakeText;

    public void OnClickGiveCakeButton()
    {
        if (FoodScript.Cake >= 1)
        {
            if (GiveAppleScript.TodayFood <= GiveAppleScript.limit)
            {
                GiveText.text = "�P�[�L����������I";

                EvoScript.GiveCake++;
                FoodScript.Cake--;
                GiveAppleScript.TodayFood++;
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
