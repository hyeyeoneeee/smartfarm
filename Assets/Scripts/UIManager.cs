using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject uiPanel; // ��� UI �г�

    void Start()
    {
        // �ʱ⿡�� UI�� ��Ȱ��ȭ
        uiPanel.SetActive(false);
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
}
