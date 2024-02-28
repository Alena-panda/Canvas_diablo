using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClose : MonoBehaviour
{
    [SerializeField] private Button _closeButton;

    private void OnEnable()
    {
        //добавляем событие
        _closeButton.onClick.AddListener(ButtonClick);
    }

    public void ButtonClick()
    {
        MessageBox.Instance.gameObject.SetActive(false); //включени или выключен (виден на экране или нет) закрыт или нет
    }

    private void OnDisable()
    {
        //отписка для очистки памяти
        _closeButton.onClick.RemoveAllListeners();
    }
}
