using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EvoToHomeScript : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("HomeScene" + EvoScript.HomeNumber.ToString());
    }
}
