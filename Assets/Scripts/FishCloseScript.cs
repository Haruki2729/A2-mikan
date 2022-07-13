using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCloseScript : MonoBehaviour
{
    public void OnClickFishCloseButton()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Fish");

        foreach (GameObject ball in objects)
        {
            ball.gameObject.SetActive(false);
        }
    }
}
