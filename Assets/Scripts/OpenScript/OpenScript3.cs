using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScript3 : MonoBehaviour
{
    public static int c = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (c == 1)
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("number3");

            foreach (GameObject ball in objects)
            {
                ball.gameObject.SetActive(false);
            }
        }
    }
}
