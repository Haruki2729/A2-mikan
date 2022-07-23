using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No3CloseScript : MonoBehaviour
{
    public void OnClickNo1CloseButton()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("No3");

        foreach (GameObject ball in objects)
        {
            ball.gameObject.SetActive(false);
        }
    }
}
