using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseScript : MonoBehaviour
{
    // ボタンが押された場合、今回呼び出される関数
    public void OnClickCloseButton()
    {
        // ホームシーンへ移動
        SceneManager.LoadScene("HomeScene");
    }
}
