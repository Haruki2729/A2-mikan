using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButtonScript : MonoBehaviour
{
    // �{�^���������ꂽ�ꍇ�A����Ăяo�����֐�
    public void OnClickHomeButton()
    {
        EvoScript.GiveApple = 0;
        EvoScript.GiveChicken = 0;
        EvoScript.GiveFish = 0;
        EvoScript.GiveCake = 0;

        // �z�[���V�[���ֈړ�
        SceneManager.LoadScene("HomeScene" + EvoScript.HomeNumber.ToString());
    }
}
