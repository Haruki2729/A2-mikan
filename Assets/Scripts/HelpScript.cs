using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpScript : MonoBehaviour
{
    // �{�^���������ꂽ�ꍇ�A����Ăяo�����֐�
    public void OnClickHelpButton()
    {
        // �z�[���V�[���ֈړ�
        SceneManager.LoadScene("HelpScene");
    }
}
