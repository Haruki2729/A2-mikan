using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScript8 : MonoBehaviour
{
    public static int h = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (h == 1)
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("number8");

            foreach (GameObject ball in objects)
            {
                ball.gameObject.SetActive(false);
            }
        }
    }
}
