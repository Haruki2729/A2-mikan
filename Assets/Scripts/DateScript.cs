using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateScript : MonoBehaviour
{
    public Text DateText;

    public static int Foodgauge = 1;//�a�Q�[�W������
    public static int Date = 1;//����������

    //���̃X�N���v�g�������Ŏg����ϐ�
    //public static int NowHourTime;
    //public static int NowMinuteTime;
    //public static int NowSecondTime;

    // Start is called before the first frame update
    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {
        //���ݎ������擾
        int NowHourTime = System.DateTime.Now.Hour;
        int NowMinuteTime = System.DateTime.Now.Minute;
        int NowSecondTime = System.DateTime.Now.Second;
        int NowMilliSecondTime = System.DateTime.Now.Millisecond;

        //�a�Q�[�W��0�Ȃ���t��1�Ƀ��Z�b�g
        if (Foodgauge == 0){
            Date = 1;
        }

        //����o��������t��i�߂�
        if(NowHourTime == 0 && NowMinuteTime == 0 && NowSecondTime == 0)
        {
            Date++;
        }

        //if(System.DateTime.Now.Hour==0 && )

        DateText.text = Date.ToString();
    }
}
