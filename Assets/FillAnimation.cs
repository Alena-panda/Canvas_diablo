using UnityEngine;
using UnityEngine.UI;

public class myScript : MonoBehaviour
{
    //����� ��������� ��������� �������� � GameObject (������������� � FillController)
    //����������� ���������� ��� ������ ������ ������ GameObject
    [SerializeField] private Image _image;
    private float _time = 0;
    int colorValue = 255;

    private void Update()
    {
        _image.fillAmount = _time; //����� ���������� �������� (image type=filled)
        _time += Time.deltaTime / 10;

        //������ ������ ��������
        _image.color = new Color(_time*colorValue,_time*colorValue, _time * colorValue);
        _time += Time.deltaTime / 100;
    }

    public void ButtonClick()
    {
        Debug.Log("���� ����������!");
    }


}
