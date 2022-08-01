using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EatFoodScript : MonoBehaviour
{
    //テキストの用意
    public Text EatAppleText;
    public Text EatChickenText;
    public Text EatFishText;
    public Text EatCakeText;

    void Start()
    {

    }

    void Update()
    {
        EatAppleText.text = EvoScript.GiveApple.ToString();
        EatChickenText.text = EvoScript.GiveChicken.ToString();
        EatFishText.text = EvoScript.GiveFish.ToString();
        EatCakeText.text = EvoScript.GiveCake.ToString();
    }



}
