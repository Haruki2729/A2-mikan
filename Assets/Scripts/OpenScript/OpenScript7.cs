using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScript7 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EvoScript.No6 == 1)
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("number7");

            foreach (GameObject ball in objects)
            {
                ball.gameObject.SetActive(false);
            }
        }
    }
}
