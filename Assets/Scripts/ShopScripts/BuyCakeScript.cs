using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyCakeScript : MonoBehaviour
{
    //�w�������E���s�p�̃e�L�X�g�I�u�W�F�N�g
    public Text GetText;
    public Text ErrorText;

    public void OnClickCakeYesButton()
    {
        //�R�C���̏����������z�ȏォ�ǂ���
        if(CoinScript.coin >= 1000){
            FoodScript.Cake++;//�`�L������������
            CoinScript.coin -= 1000;//�R�C������
            GetText.text = "�P�[�L���w�����܂����I";//�e�L�X�g�\��
            StartCoroutine("TextSet");//�R���[�`�������s
        }
        else
        {
            ErrorText.text = "�R�C��������܂���";//�e�L�X�g�\��
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
