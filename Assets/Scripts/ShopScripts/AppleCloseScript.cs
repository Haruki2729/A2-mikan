using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleCloseScript : MonoBehaviour
{
    public void OnClickAppleCloseButton()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Apple");

        foreach (GameObject ball in objects)
        {
            ball.gameObject.SetActive(false);
        }
    }
}
