using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyAppleScript : MonoBehaviour
{
    public Text GetText;
    public Text ErrorText;

    public int test = 100;

    public void OnClickAppleYesButton()
    {
        if(test >= 100){
            //Debug.Log(FoodScript.Apple);
            //Apple++;
            //coin -= 100;
            GetText.text = "��񂲂��w�����܂����I";
            StartCoroutine("TextSet");//�R���[�`�������s
        }
        else
        {
            ErrorText.text = "�R�C��������܂���";
            StartCoroutine("TextSet");//�R���[�`�������s
        }
    }

    IEnumerator TextSet()
    {
        yield return new WaitForSeconds(1.0f);
        GetText.text = "";
        ErrorText.text = "";
    }

}
