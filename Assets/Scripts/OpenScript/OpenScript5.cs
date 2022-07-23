using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScript5 : MonoBehaviour
{
    public static int e = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (e == 1)
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("number5");

            foreach (GameObject ball in objects)
            {
                ball.gameObject.SetActive(false);
            }
        }
    }
}
