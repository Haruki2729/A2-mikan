using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionCoin : MonoBehaviour
{
    // �{�^���������ꂽ�ꍇ�A����Ăяo�����֐�
    public void OnClickHomeButton()
    {
        // �z�[���V�[���ֈړ�
        SceneManager.LoadScene("HomeScene" + EvoScript.HomeNumber.ToString());
        CoinScript.coin += 100;
    }
}
