using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScript : MonoBehaviour
{
    public static int a = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (a == 1)
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("number0");

            foreach (GameObject ball in objects)
            {
                ball.gameObject.SetActive(false);
            }
        }
    }
}
