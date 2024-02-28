using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClose : MonoBehaviour
{
    [SerializeField] private Button _closeButton;

    private void OnEnable()
    {
        //��������� �������
        _closeButton.onClick.AddListener(ButtonClick);
    }

    public void ButtonClick()
    {
        MessageBox.Instance.gameObject.SetActive(false); //�������� ��� �������� (����� �� ������ ��� ���) ������ ��� ���
    }

    private void OnDisable()
    {
        //������� ��� ������� ������
        _closeButton.onClick.RemoveAllListeners();
    }
}
