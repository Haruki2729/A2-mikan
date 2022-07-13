using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpScript : MonoBehaviour
{
    // ボタンが押された場合、今回呼び出される関数
    public void OnClickHelpButton()
    {
        // ホームシーンへ移動
        SceneManager.LoadScene("HelpScene");
    }
}
