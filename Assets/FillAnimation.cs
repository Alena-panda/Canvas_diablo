using UnityEngine;
using UnityEngine.UI;

public class myScript : MonoBehaviour
{
    //чтобы управлять картинкой вкинутой в GameObject (переименовали в FillController)
    //прописываем конкретный тип данных вместо общего GameObject
    [SerializeField] private Image _image;
    private float _time = 0;
    int colorValue = 255;

    private void Update()
    {
        _image.fillAmount = _time; //время заполнения картинки (image type=filled)
        _time += Time.deltaTime / 10;

        //залить цветом картинку
        _image.color = new Color(_time*colorValue,_time*colorValue, _time * colorValue);
        _time += Time.deltaTime / 100;
    }

    public void ButtonClick()
    {
        Debug.Log("Игра начинается!");
    }


}
