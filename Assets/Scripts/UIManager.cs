using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject uiPanel; // 띄울 UI 패널

    void Start()
    {
        // 초기에는 UI를 비활성화
        uiPanel.SetActive(false);
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
}
