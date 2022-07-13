using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeCloseScript : MonoBehaviour
{
    public void OnClickCakeCloseButton()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Cake");

        foreach (GameObject ball in objects)
        {
            ball.gameObject.SetActive(false);
        }
    }
}
