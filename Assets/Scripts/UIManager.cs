using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject uiPanel; // 띄울 UI 패널
    private int temCount; //온도숫자
    private int HuCount; //습도숫자
    public TextMeshProUGUI temText; //온도 텍스트
    public TextMeshProUGUI HuText; //습도 텍스트

    void Start()
    {
        // 초기에는 UI를 비활성화
        uiPanel.SetActive(false);
        temCount = 10;
        HuCount = 60;
        PlusTemCount();
        PlusHuCount();
    }

    public void ShowUI()
    {
        // 버튼을 누르면 호출되는 메서드
        uiPanel.SetActive(true);
    }
    public void CloseUI() 
    {
        // UI 닫기 버튼 등을 누를 때 호출되는 메서드
        uiPanel.SetActive(false);
    }
    #region Count
    public void PlusTemCount() //온도 증가 카운트 메서드
    {
        temCount += 5;
        temText.text = temCount.ToString() + "°C";
    }
    public void PlusHuCount() //습도 증가 카운트 메서드
    {
        HuCount += 5;
        HuText.text = HuCount.ToString() + "%";
    }
    public void MinusTemCount()
    {
        temCount -= 5;
        temText.text = temCount.ToString() + "°C";
    }
    public void MinusHuCount()
    {
        HuCount -= 5;
        HuText.text = HuCount.ToString() + "%";
    }
    #endregion


}
