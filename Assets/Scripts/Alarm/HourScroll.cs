using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class HourScroll : MonoBehaviour, IEndDragHandler
{
    // 定数
    public float PICKER_H_NUM = 10; // 数値ピッカーの要素数
    private float DEFAULT_POSITION = 0.5f;    // スクロールの定位置
    public int MAX_H_NUM = 9;    // ピッカーの数値の最大値
    float max = 9f; //要素数-1

    // オブジェクト参照
    public GameObject Viewport; // 数値ピッカーの数値要素の親オブジェクト

    // メンバ変数
    public int currentHNum = 0; // 現在の数値ピッカーの値
    private int centerHNum;  // 数値ピッカーの中で中央に来るオブジェクトの順番。PICKER_NUM / 2 を四捨五入した値

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<ScrollRect>().verticalNormalizedPosition = DEFAULT_POSITION;
        centerHNum = Mathf.RoundToInt(PICKER_H_NUM / 2);
    }

    // ドラッグ終了時
    public void OnEndDrag(PointerEventData data)
    {
        // 中央からの移動距離を求める
        float pos = Mathf.Clamp(this.GetComponent<ScrollRect>().verticalNormalizedPosition, 0, 1);
        //int move = Mathf.RoundToInt((pos - DEFAULT_POSITION) * PICKER_H_NUM * -1);
        int num = Mathf.RoundToInt(max - max * pos);

        // 数値ピッカーを移動後の状態に更新する
        //UpdatePickerNum(currentHNum + move);
        UpdatePickerNum(num);

    }

    // ピッカーに指定した値を設定する
    public void UpdatePickerNum(int value)
    {

        currentHNum = AdjustNumber(value);
        Debug.Log(currentHNum);

        // 移動後の値に各要素のtextを書き換える
        for (int i = 0; i < PICKER_H_NUM; i++)
        {
            Viewport.transform.GetChild(i).gameObject.GetComponent<TextMeshPro>().text =
                    AdjustNumber(currentHNum + i + 1 - centerHNum).ToString();
        }
        // スクロール位置を初期位置に戻す
        this.GetComponent<ScrollRect>().verticalNormalizedPosition = DEFAULT_POSITION;
       
    }

    // 各要素に設定する数値を範囲内に収める
    private int AdjustNumber(int num)
    {
        while (num > MAX_H_NUM)
        {
            num -= (MAX_H_NUM + 1);
        }
        while (num < 0)
        {
            num += (MAX_H_NUM + 1);
        }
        return num;
    }
}