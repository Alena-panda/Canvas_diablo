using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class ToggleScrypt : MonoBehaviour
{
    [SerializeField] Toggle _toggle;
    [SerializeField] Image _imageBackground;//цвет тогла

    private void Start()
    {
        _toggle.onValueChanged.AddListener(ToggleMethod);
    }

    private void ToggleMethod(bool toggleState)
    {
        if(toggleState)
        {
            _imageBackground.color = Color.red;
        }
        else
        {
            _imageBackground.color = Color.green;
        }

    }

}
