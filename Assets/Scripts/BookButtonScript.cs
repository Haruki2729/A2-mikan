using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BookButtonScript : MonoBehaviour
{
    // �{�^���������ꂽ�ꍇ�A����Ăяo�����֐�
    public void OnClickBookButton()
    {
        // �z�[���V�[���ֈړ�
        SceneManager.LoadScene("BookScene");
    }
}
