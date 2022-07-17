using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodScript : MonoBehaviour
{
    //テキストの用意
    public Text AppleText;
    public Text ChikenText;
    public Text FishText;
    public Text CakeText;

    //それぞれの餌の持ち数
    public int Apple = 0;
    public int Chiken = 0;
    public int Fish = 0;
    public int Cake = 0;

    void Start()
    {
        
    }

    void Update()
    {
        //餌所持数の表示
        AppleText.text = Apple.ToString() + "個所持";
        ChikenText.text = Chiken.ToString() + "個所持";
        FishText.text = Fish.ToString() + "個所持";
        CakeText.text = Cake.ToString() + "個所持";
    }
}
