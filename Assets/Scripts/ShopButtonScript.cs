using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopButtonScript : MonoBehaviour
{
    // �{�^���������ꂽ�ꍇ�A����Ăяo�����֐�
    public void OnClickShopButton()
    {
        // �z�[���V�[���ֈړ�
        SceneManager.LoadScene("ShopScene");
    }
}
