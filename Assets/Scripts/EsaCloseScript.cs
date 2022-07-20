using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsaCloseScript : MonoBehaviour
{
    public void OnClickEsaCloseButton()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Esaelement");

        foreach (GameObject ball in objects)
        {
            ball.gameObject.SetActive(false);
        }
    }
}
