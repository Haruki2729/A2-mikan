using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodviewScript : MonoBehaviour
{
    //�e�L�X�g�̗p��
    public Text AppleText;
    public Text ChickenText;
    public Text FishText;
    public Text CakeText;

    void Start()
    {
        
    }

    void Update()
    {
        //�a�������̕\��
        AppleText.text = FoodScript.Apple.ToString() + "����";
        ChickenText.text = FoodScript.Chicken.ToString() + "����";
        FishText.text = FoodScript.Fish.ToString() + "����";
        CakeText.text = FoodScript.Cake.ToString() + "����";
    }



}
