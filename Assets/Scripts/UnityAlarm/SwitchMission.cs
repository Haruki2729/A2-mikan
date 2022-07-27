using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SwitchMission : MonoBehaviour
{
    int randomValue1;

    void Start()
    {
        

    }

    void update()
    {
        //0以上のランダムな値
        randomValue1 = Random.Range(1, 3);
        Debug.Log(randomValue1);

        switch (randomValue1)
        {
            case 1:
                SceneManager.LoadScene("Mission1Scene");
                break;
            case 2:
                SceneManager.LoadScene("Mission2Scene");
                break;
            case 3:
                Debug.Log("3やで");
                break;
        }
    }

}
