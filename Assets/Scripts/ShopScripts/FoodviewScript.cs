using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodviewScript : MonoBehaviour
{
    //テキストの用意
    public Text AppleText;
    public Text ChickenText;
    public Text FishText;
    public Text CakeText;

    void Start()
    {
        
    }

    void Update()
    {
        //餌所持数の表示
        AppleText.text = FoodScript.Apple.ToString() + "個所持";
        ChickenText.text = FoodScript.Chicken.ToString() + "個所持";
        FishText.text = FoodScript.Fish.ToString() + "個所持";
        CakeText.text = FoodScript.Cake.ToString() + "個所持";
    }



}
