using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using TMPro;

public class Shake : MonoBehaviour
{

    private Vector3 Acceleration;
    private Vector3 preAcceleration;
    float DotProduct;
    public static int ShakeCount;
    //public TextMeshProUGUI ShakeText;
    public Text ShakeTextL;

    void Start()
    {
        ShakeCount = 0;
        //ShakeText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        preAcceleration = Acceleration;
        Acceleration = Input.acceleration;
        DotProduct = Vector3.Dot(Acceleration, preAcceleration);
        if (DotProduct < 0)
        {
            ShakeCount++;
        }
        Debug.Log("ShakeCount = " + ShakeCount);
        //ShakeText.text = ShakeCount.ToString("000") + "‰ñ";
        ShakeTextL.text = ShakeCount.ToString("000") + "‰ñ";
        //AppleText.text = Apple.ToString() + "ŒÂŠŽ";


        if (ShakeCount == 10)
        {
            ShakeCount = 0;
            // SceneManager.LoadScene("Clear");
            //ShakeText.text = ("Clear");
            ShakeTextL.text = ("Clear");
            SceneManager.LoadScene("MissionClearScene");
        }
    }



}