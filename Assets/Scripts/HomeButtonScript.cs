using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButtonScript : MonoBehaviour
{
    // �{�^���������ꂽ�ꍇ�A����Ăяo�����֐�
    public void OnClickHomeButton()
    {
        // �z�[���V�[���ֈړ�
        SceneManager.LoadScene("HomeScene");
    }
}
