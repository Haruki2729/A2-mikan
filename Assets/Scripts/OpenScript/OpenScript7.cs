using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScript7 : MonoBehaviour
{
    public static int g = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (g == 1)
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("number7");

            foreach (GameObject ball in objects)
            {
                ball.gameObject.SetActive(false);
            }
        }
    }
}
