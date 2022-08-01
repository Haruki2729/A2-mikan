using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GiveFishScript : MonoBehaviour
{

    public Text GiveText;
    public Text CantText;
    public Text LackText;

    public TextMeshProUGUI EatFishText;

    public void OnClickGiveFishButton()
    {
        if (FoodScript.Fish >= 1)
        {
            if (GiveAppleScript.TodayFood <= GiveAppleScript.limit)
            {
                GiveText.text = "�������Ȃ���������I";
                StartCoroutine("TextSet");//�R���[�`�������s

                EvoScript.GiveFish++;
                FoodScript.Fish--;
                GiveAppleScript.TodayFood++;
                EatFishText.text = EvoScript.GiveFish.ToString();
            }
            else
            {
                CantText.text = "�����͂����a��^�����Ȃ���";
                StartCoroutine("TextSet");//�R���[�`�������s
            }
        }
        else
        {
            LackText.text = "�������Ȃ�����Ȃ���";
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
