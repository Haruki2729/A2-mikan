using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlarmButtonScript: MonoBehaviour
{
    // �{�^���������ꂽ�ꍇ�A����Ăяo�����֐�
    public void OnClickAlarmButton()
    {
        // �A���[���V�[���ֈړ�
        SceneManager.LoadScene("UnityAlarmScene");
    }
}