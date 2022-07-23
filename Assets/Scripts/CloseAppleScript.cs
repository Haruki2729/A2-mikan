using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseAppleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickGiveAppleButton()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("GiveApple");

        foreach (GameObject ball in objects)
        {
            ball.gameObject.SetActive(false);
        }
    }
}
