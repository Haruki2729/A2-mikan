using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodScript : MonoBehaviour
{
    //�e�L�X�g�̗p��
    public Text AppleText;
    public Text ChikenText;
    public Text FishText;
    public Text CakeText;

    //���ꂼ��̉a�̎�����
    public int Apple = 0;
    public int Chiken = 0;
    public int Fish = 0;
    public int Cake = 0;

    void Start()
    {
        
    }

    void Update()
    {
        //�a�������̕\��
        AppleText.text = Apple.ToString() + "����";
        ChikenText.text = Chiken.ToString() + "����";
        FishText.text = Fish.ToString() + "����";
        CakeText.text = Cake.ToString() + "����";
    }
}
