using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GiveChickenScript : MonoBehaviour
{

    public Text GiveText;
    public Text CantText;
    public Text LackText;

    public TextMeshProUGUI EatChickenText;

    public void OnClickGiveChickenButton()
    {
        if (FoodScript.Chicken >= 1)
        {
            if (GiveAppleScript.TodayFood <= GiveAppleScript.limit)
            {

                GiveText.text = "�`�L������������";
                StartCoroutine("TextSet");//�R���[�`�������s

                EvoScript.GiveChicken++;
                FoodScript.Chicken--;
                GiveAppleScript.TodayFood++;
                EatChickenText.text = EvoScript.GiveChicken.ToString();
            }
            else
            {
                CantText.text = "�����͂����a���������Ȃ���";
                StartCoroutine("TextSet");//�R���[�`�������s

            }
        }
        else
        {

            LackText.text = "�`�L��������Ȃ���";
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
