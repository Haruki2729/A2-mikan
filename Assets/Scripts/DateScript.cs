using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateScript : MonoBehaviour
{
    public Text DateText;

    public static int Foodgauge = 0;//�a�Q�[�W������
    public static int Date = 1;//����������

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�a�Q�[�W��0�Ȃ���t��1�Ƀ��Z�b�g
        if (Foodgauge == 0){
            Date = 1;
        }

        DateText.text = Date.ToString();
    }
}
