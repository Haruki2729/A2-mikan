using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyFishScript : MonoBehaviour
{
    //�w�������E���s�p�̃e�L�X�g�I�u�W�F�N�g
    public Text GetText;
    public Text ErrorText;

    public void OnClickChickenYesButton()
    {
        //�R�C���̏����������z�ȏォ�ǂ���
        if(CoinScript.coin >= 400){
            FoodScript.Fish++;//�������ȏ���������
            CoinScript.coin -= 400;//�R�C������
            GetText.text = "�������Ȃ��w�����܂����I";//�e�L�X�g�\��
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
