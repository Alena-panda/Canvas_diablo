using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClicker : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Button _clickButton;
    private int counter = 0;

    private void Start()
    {
        _clickButton.onClick.AddListener(SetText);
        _text.text = counter.ToString();
    }

    private void SetText()
    {
        counter++;
        _text.text = counter.ToString();
    }
}
