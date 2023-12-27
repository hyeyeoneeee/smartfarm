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

    //파티클 변수
    //public ParticleSystem heaterParticle;

    void Start()
    {
        // 초기에는 UI를 비활성화
        uiPanel.SetActive(false);

        // 온습도 카운트 초기화
        temCount = 10;
        HuCount = 60;
        PlusTemCount();
        PlusHuCount();

        //Button button = GetComponent<Button>(); // 버튼 컴포넌트를 가져옴
        //button.onClick.AddListener(HeParticle); //클릭 이벤트에 PlayParticle 메서드를 연결
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
    #region -----------------Count------------------------
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

    #region -------------Particle--------------------------
    //public void HeParticle() //히터 아이콘 클릭시 파티클 호출 메서드
    //{
    //    heaterParticle.Play();
    //}
    #endregion
}
