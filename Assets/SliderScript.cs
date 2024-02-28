using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public class SliderScript : MonoBehaviour
{
    private Slider _slider;
    private Light _light;

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _light = FindObjectOfType<Light>();

        _slider.value = _light.intensity;
        _slider.onValueChanged.AddListener(ChangeNewValue);
    }

    //регулируем солнышко на сцене
    private void ChangeNewValue(float newValue)
    {
        _light.intensity = newValue;
    }
}


