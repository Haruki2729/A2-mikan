using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Book2ButtonScript : MonoBehaviour
{
    // ボタンが押された場合、今回呼び出される関数
    public void OnClickBook2Button()
    {
        // ホームシーンへ移動
        SceneManager.LoadScene("Book2Scene");
    }
}
