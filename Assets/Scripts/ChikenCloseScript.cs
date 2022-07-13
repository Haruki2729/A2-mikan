using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChikenCloseScript : MonoBehaviour
{
    public void OnClickChikenCloseButton()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Chiken");

        foreach (GameObject ball in objects)
        {
            ball.gameObject.SetActive(false);
        }
    }
}
