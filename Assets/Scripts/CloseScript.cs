using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseScript : MonoBehaviour
{
    // �{�^���������ꂽ�ꍇ�A����Ăяo�����֐�
    public void OnClickCloseButton()
    {
        // �z�[���V�[���ֈړ�
        SceneManager.LoadScene("HomeScene");
    }
}
