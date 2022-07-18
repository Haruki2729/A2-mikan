using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodScript : MonoBehaviour
{
    //テキストの用意
    public Text AppleText;
    public Text ChickenText;
    public Text FishText;
    public Text CakeText;

    //それぞれの餌の持ち数
    public static int Apple = 0;
    public static int Chicken = 0;
    public static int Fish = 0;
    public static int Cake = 0;

    void Start()
    {
        
    }

    void Update()
    {
        //餌所持数の表示
        AppleText.text = Apple.ToString() + "個所持";
        ChickenText.text = Chicken.ToString() + "個所持";
        FishText.text = Fish.ToString() + "個所持";
        CakeText.text = Cake.ToString() + "個所持";
    }

    public static int returnApple()
    {
        return Apple;
    }

    public static int returnChicken()
    {
        return Chicken;
    }

    public static int returnFish()
    {
        return Fish;
    }

    public static int returnCake()
    {
        return Cake;
    }
}
