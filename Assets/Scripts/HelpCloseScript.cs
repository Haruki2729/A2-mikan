using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpCloseScript : MonoBehaviour
{
    public void OnClickHelpCloseButton()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Helpelement");

        foreach (GameObject ball in objects)
        {
            ball.gameObject.SetActive(false);
        }
    }
}
