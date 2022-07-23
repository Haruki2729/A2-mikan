using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScript9 : MonoBehaviour
{
    public static int iii = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (iii == 1)
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("number9");

            foreach (GameObject ball in objects)
            {
                ball.gameObject.SetActive(false);
            }
        }
    }
}
