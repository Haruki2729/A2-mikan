using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsaClose2Script : MonoBehaviour
{
    public void OnClickEsaCloseButton()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Esaelement2");

        foreach (GameObject ball in objects)
        {
            ball.gameObject.SetActive(false);
        }
    }
}
