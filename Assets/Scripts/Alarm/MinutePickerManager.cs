using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class MinutePickerManager : MonoBehaviour, IEndDragHandler
{
    // 定数
    public float PICKER_M_NUM = 10; // 数値ピッカーの要素数
    private float DEFAULT_POSITION = 0.5f;    // スクロールの定位置
    public int MAX_MNUM = 9;    // ピッカーの数値の最大値

    // オブジェクト参照
    public GameObject Viewport; // 数値ピッカーの数値要素の親オブジェクト

    // メンバ変数
    public int currentMNum = 0;// 現在の数値ピッカーの値
    private int centerMNum;  // 数値ピッカーの中で中央に来るオブジェクトの順番。PICKER_NUM / 2 を四捨五入した値

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<ScrollRect>().verticalNormalizedPosition = DEFAULT_POSITION;
        centerMNum = Mathf.RoundToInt(PICKER_M_NUM / 2);
    }

    // ドラッグ終了時
    public void OnEndDrag(PointerEventData data)
    {
        // 中央からの移動距離を求める
        float pos = Mathf.Clamp(this.GetComponent<ScrollRect>().verticalNormalizedPosition, 0, 1);
        int move = Mathf.RoundToInt((pos - DEFAULT_POSITION) *PICKER_M_NUM * -1);
        // 数値ピッカーを移動後の状態に更新する
        UpdatePickerNum(currentMNum + move);
    }

    // ピッカーに指定した値を設定する
    public void UpdatePickerNum(int value)
    {
        
        currentMNum = AdjustNumber(value);
        Debug.Log(currentMNum);

        // 移動後の値に各要素のtextを書き換える
        for (int i = 0; i <PICKER_M_NUM; i++)
        {
            Viewport.transform.GetChild(i).gameObject.GetComponent<TextMeshPro>().text =
                    AdjustNumber(currentMNum + i + 1 - centerMNum).ToString();
        }
        // スクロール位置を初期位置に戻す
        this.GetComponent<ScrollRect>().verticalNormalizedPosition = DEFAULT_POSITION;
    }

    // 各要素に設定する数値を範囲内に収める
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