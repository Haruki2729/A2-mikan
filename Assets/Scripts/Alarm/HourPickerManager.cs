using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class HourPickerManager : MonoBehaviour, IEndDragHandler
{
    // �萔
    public float PICKER_NUM = 10; // ���l�s�b�J�[�̗v�f��
    private float DEFAULT_POSITION = 0.5f;    // �X�N���[���̒�ʒu
    public int MAX_NUM = 9;    // �s�b�J�[�̐��l�̍ő�l

    // �I�u�W�F�N�g�Q��
    public GameObject Viewport; // ���l�s�b�J�[�̐��l�v�f�̐e�I�u�W�F�N�g

    // �����o�ϐ�
    public int currentNum = 0; // ���݂̐��l�s�b�J�[�̒l
    private int centerNum;  // ���l�s�b�J�[�̒��Œ����ɗ���I�u�W�F�N�g�̏��ԁBPICKER_NUM / 2 ���l�̌ܓ������l

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<ScrollRect>().verticalNormalizedPosition = DEFAULT_POSITION;
        centerNum = Mathf.RoundToInt(PICKER_NUM / 2);
    }

    // �h���b�O�I����
    public void OnEndDrag(PointerEventData data)
    {
        // ��������̈ړ����������߂�
        float pos = Mathf.Clamp(this.GetComponent<ScrollRect>().verticalNormalizedPosition, 0, 1);
        int move = Mathf.RoundToInt((pos - DEFAULT_POSITION) * PICKER_NUM * -1);

        // ���l�s�b�J�[���ړ���̏�ԂɍX�V����
        UpdatePickerNum(currentNum + move);
        Debug.Log(currentNum);
    }

    // �s�b�J�[�Ɏw�肵���l��ݒ肷��
    public void UpdatePickerNum(int value)
    {
        currentNum = AdjustNumber(value);
        // �ړ���̒l�Ɋe�v�f��text������������
        for (int i = 0; i < PICKER_NUM; i++)
        {
            Viewport.transform.GetChild(i).gameObject.GetComponent<TextMeshPro>().text =
                    AdjustNumber(currentNum + i + 1 - centerNum).ToString();
        }
        // �X�N���[���ʒu�������ʒu�ɖ߂�
        this.GetComponent<ScrollRect>().verticalNormalizedPosition = DEFAULT_POSITION;
    }

    // �e�v�f�ɐݒ肷�鐔�l��͈͓��Ɏ��߂�
    private int AdjustNumber(int num)
    {
        while (num > MAX_NUM)
        {
            num -= (MAX_NUM + 1);
        }
        while (num < 0)
        {
            num += (MAX_NUM + 1);
        }
        return num;
    }
}