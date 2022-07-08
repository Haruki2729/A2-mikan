using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlarmButtonScript: MonoBehaviour
{
    // ボタンが押された場合、今回呼び出される関数
    public void OnClickAlarmButton()
    {
        // アラームシーンへ移動
        SceneManager.LoadScene("AlarmScene");
    }
}