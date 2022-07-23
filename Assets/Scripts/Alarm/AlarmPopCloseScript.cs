using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmPopCloseScript : MonoBehaviour
{
    public void OnClickAlarmReturnButton()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Alarm");

        foreach (GameObject ball in objects)
        {
            ball.gameObject.SetActive(false);
        }
    }
}
