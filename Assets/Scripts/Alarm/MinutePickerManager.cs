using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class MinutePickerManager : MonoBehaviour, IEndDragHandler
{
    // �萔
    public float PICKER_M_NUM = 10; // ���l�s�b�J�[�̗v�f��
    private float DEFAULT_POSITION = 0.5f;    // �X�N���[���̒�ʒu
    public int MAX_MNUM = 9;    // �s�b�J�[�̐��l�̍ő�l

    // �I�u�W�F�N�g�Q��
    public GameObject Viewport; // ���l�s�b�J�[�̐��l�v�f�̐e�I�u�W�F�N�g

    // �����o�ϐ�
    public int currentMNum = 0;// ���݂̐��l�s�b�J�[�̒l
    private int centerMNum;  // ���l�s�b�J�[�̒��Œ����ɗ���I�u�W�F�N�g�̏��ԁBPICKER_NUM / 2 ���l�̌ܓ������l

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<ScrollRect>().verticalNormalizedPosition = DEFAULT_POSITION;
        centerMNum = Mathf.RoundToInt(PICKER_M_NUM / 2);
    }

    // �h���b�O�I����
    public void OnEndDrag(PointerEventData data)
    {
        // ��������̈ړ����������߂�
        float pos = Mathf.Clamp(this.GetComponent<ScrollRect>().verticalNormalizedPosition, 0, 1);
        int move = Mathf.RoundToInt((pos - DEFAULT_POSITION) *PICKER_M_NUM * -1);
        // ���l�s�b�J�[���ړ���̏�ԂɍX�V����
        UpdatePickerNum(currentMNum + move);
    }

    // �s�b�J�[�Ɏw�肵���l��ݒ肷��
    public void UpdatePickerNum(int value)
    {
        
        currentMNum = AdjustNumber(value);
        Debug.Log(currentMNum);

        // �ړ���̒l�Ɋe�v�f��text������������
        for (int i = 0; i <PICKER_M_NUM; i++)
        {
            Viewport.transform.GetChild(i).gameObject.GetComponent<TextMeshPro>().text =
                    AdjustNumber(currentMNum + i + 1 - centerMNum).ToString();
        }
        // �X�N���[���ʒu�������ʒu�ɖ߂�
        this.GetComponent<ScrollRect>().verticalNormalizedPosition = DEFAULT_POSITION;
    }

    // �e�v�f�ɐݒ肷�鐔�l��͈͓��Ɏ��߂�
    private int AdjustNumber(int num)
    {
        while (num > MAX_MNUM)
        {
            num -= (MAX_MNUM + 1);
        }
        while (num < 0)
        {
            num += (MAX_MNUM + 1);
        }
        return num;
    }
}