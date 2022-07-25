using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionCoin : MonoBehaviour
{
    // ボタンが押された場合、今回呼び出される関数
    public void OnClickHomeButton()
    {
        // ホームシーンへ移動
        SceneManager.LoadScene("HomeScene" + EvoScript.HomeNumber.ToString());
        CoinScript.coin += 100;
    }
}
