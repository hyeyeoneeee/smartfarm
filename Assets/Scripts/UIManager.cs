using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject uiPanel; // ��� UI �г�
    private int temCount; //�µ�����
    private int HuCount; //��������
    public TextMeshProUGUI temText; //�µ� �ؽ�Ʈ
    public TextMeshProUGUI HuText; //���� �ؽ�Ʈ

    void Start()
    {
        // �ʱ⿡�� UI�� ��Ȱ��ȭ
        uiPanel.SetActive(false);
        temCount = 10;
        HuCount = 60;
        PlusTemCount();
        PlusHuCount();
    }

    public void ShowUI()
    {
        // ��ư�� ������ ȣ��Ǵ� �޼���
        uiPanel.SetActive(true);
    }
    public void CloseUI() 
    {
        // UI �ݱ� ��ư ���� ���� �� ȣ��Ǵ� �޼���
        uiPanel.SetActive(false);
    }
    #region Count
    public void PlusTemCount() //�µ� ���� ī��Ʈ �޼���
    {
        temCount += 5;
        temText.text = temCount.ToString() + "��C";
    }
    public void PlusHuCount() //���� ���� ī��Ʈ �޼���
    {
        HuCount += 5;
        HuText.text = HuCount.ToString() + "%";
    }
    public void MinusTemCount()
    {
        temCount -= 5;
        temText.text = temCount.ToString() + "��C";
    }
    public void MinusHuCount()
    {
        HuCount -= 5;
        HuText.text = HuCount.ToString() + "%";
    }
    #endregion


}
