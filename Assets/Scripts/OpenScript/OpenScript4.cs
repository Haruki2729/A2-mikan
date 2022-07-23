using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScript4 : MonoBehaviour
{
    public static int d = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (d == 1)
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("number4");

            foreach (GameObject ball in objects)
            {
                ball.gameObject.SetActive(false);
            }
        }
    }
}
