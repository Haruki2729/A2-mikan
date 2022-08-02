using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButtonScript : MonoBehaviour
{
    // ボタンが押された場合、今回呼び出される関数
    public void OnClickHomeButton()
    {
        EvoScript.GiveApple = 0;
        EvoScript.GiveChicken = 0;
        EvoScript.GiveFish = 0;
        EvoScript.GiveCake = 0;

        // ホームシーンへ移動
        SceneManager.LoadScene("HomeScene" + EvoScript.HomeNumber.ToString());
    }
}
