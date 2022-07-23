using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveChickenScript : MonoBehaviour
{

    public Text GiveText;
    public Text CantText;
    public Text LackText;


    public void OnClickGiveChickenButton()
    {
        if (FoodScript.Chicken >= 1)
        {
            if (GiveAppleScript.TodayFood <= 3)
            {

                GiveText.text = "�`�L������������";
                StartCoroutine("TextSet");//�R���[�`�������s

                EvoScript.GiveChicken++;
                FoodScript.Chicken--;
                GiveAppleScript.TodayFood++;
                EvoScript.GiveChicken++;
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
