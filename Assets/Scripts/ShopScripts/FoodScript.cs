using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodScript : MonoBehaviour
{
    //�e�L�X�g�̗p��
    public Text AppleText;
    public Text ChickenText;
    public Text FishText;
    public Text CakeText;

    //���ꂼ��̉a�̎�����
    public static int Apple = 0;
    public static int Chicken = 0;
    public static int Fish = 0;
    public static int Cake = 0;

    void Start()
    {
        
    }

    void Update()
    {
        //�a�������̕\��
        AppleText.text = Apple.ToString() + "����";
        ChickenText.text = Chicken.ToString() + "����";
        FishText.text = Fish.ToString() + "����";
        CakeText.text = Cake.ToString() + "����";
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
