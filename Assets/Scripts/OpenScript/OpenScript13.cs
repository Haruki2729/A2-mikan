using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScript13 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EvoScript.No12 == 1)
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("number13");

            foreach (GameObject ball in objects)
            {
                ball.gameObject.SetActive(false);
            }
        }
    }
}
