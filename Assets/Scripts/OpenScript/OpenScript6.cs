using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScript6 : MonoBehaviour
{
    public static int f = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (f == 1)
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("number6");

            foreach (GameObject ball in objects)
            {
                ball.gameObject.SetActive(false);
            }
        }
    }
}
