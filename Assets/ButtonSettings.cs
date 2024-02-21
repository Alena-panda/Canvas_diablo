using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSettings : MonoBehaviour
{
    [SerializeField] private Button _settingsButton;
    [SerializeField] private Transform _settingsPanel;

    private void Start()
    {
        _settingsButton.onClick.AddListener(SettingsClick);
    }

    private void SettingsClick()
    {
        MessageBox.Instance.gameObject.SetActive(true);
        MessageBox.Instance.SetText("Вы ввели текст");
    }

    //отписка
    private void OnDisable()
    {
        _settingsButton.onClick.RemoveAllListeners();
    }
}
