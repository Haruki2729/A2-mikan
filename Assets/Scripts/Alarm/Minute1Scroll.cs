using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class Minute1Scroll : MonoBehaviour, IEndDragHandler
{
    // �萔
    public float PICKER_H_NUM = 10; // ���l�s�b�J�[�̗v�f��
    private float DEFAULT_POSITION = 0.5f;    // �X�N���[���̒�ʒu
    public int MAX_M_NUM = 9;    // �s�b�J�[�̐��l�̍ő�l
    float max = 9f; //�v�f��-1

    // �I�u�W�F�N�g�Q��
    public GameObject Viewport; // ���l�s�b�J�[�̐��l�v�f�̐e�I�u�W�F�N�g

    // �����o�ϐ�
    public int currentM1Num = 0; // ���݂̐��l�s�b�J�[�̒l
    private int centerMNum;  // ���l�s�b�J�[�̒��Œ����ɗ���I�u�W�F�N�g�̏��ԁBPICKER_NUM / 2 ���l�̌ܓ������l

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<ScrollRect>().verticalNormalizedPosition = DEFAULT_POSITION;
        centerMNum = Mathf.RoundToInt(PICKER_H_NUM / 2);
    }

    // �h���b�O�I����
    public void OnEndDrag(PointerEventData data)
    {
        // ��������̈ړ����������߂�
        float pos = Mathf.Clamp(this.GetComponent<ScrollRect>().verticalNormalizedPosition, 0, 1);
        //int move = Mathf.RoundToInt((pos - DEFAULT_POSITION) * PICKER_H_NUM * -1);
        int num = Mathf.RoundToInt(max - max * pos);

        // ���l�s�b�J�[���ړ���̏�ԂɍX�V����
        //UpdatePickerNum(currentM1Num + move);
        UpdatePickerNum(num);

    }

    // �s�b�J�[�Ɏw�肵���l��ݒ肷��
    public void UpdatePickerNum(int value)
    {

        currentM1Num = AdjustNumber(value);
        Debug.Log(currentM1Num);

        // �ړ���̒l�Ɋe�v�f��text������������
        for (int i = 0; i < PICKER_H_NUM; i++)
        {
            Viewport.transform.GetChild(i).gameObject.GetComponent<TextMeshPro>().text =
                    AdjustNumber(currentM1Num + i + 1 - centerMNum).ToString();
        }
        // �X�N���[���ʒu�������ʒu�ɖ߂�
        this.GetComponent<ScrollRect>().verticalNormalizedPosition = DEFAULT_POSITION;

    }

    // �e�v�f�ɐݒ肷�鐔�l��͈͓��Ɏ��߂�
    private int AdjustNumber(int num)
    {
        while (num > MAX_M_NUM)
        {
            num -= (MAX_M_NUM + 1);
        }
        while (num < 0)
        {
            num += (MAX_M_NUM + 1);
        }
        return num;
    }
}