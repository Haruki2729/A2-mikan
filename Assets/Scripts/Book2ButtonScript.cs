using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Book2ButtonScript : MonoBehaviour
{
    // �{�^���������ꂽ�ꍇ�A����Ăяo�����֐�
    public void OnClickBook2Button()
    {
        // �z�[���V�[���ֈړ�
        SceneManager.LoadScene("Book2Scene");
    }
}
