using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No2CloseScript : MonoBehaviour
{
    public void OnClickNo1CloseButton()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("No2");

        foreach (GameObject ball in objects)
        {
            ball.gameObject.SetActive(false);
        }
    }
}
