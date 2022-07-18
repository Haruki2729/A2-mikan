using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenCloseScript : MonoBehaviour
{
    public void OnClickChickenCloseButton()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Chicken");

        foreach (GameObject ball in objects)
        {
            ball.gameObject.SetActive(false);
        }
    }
}
