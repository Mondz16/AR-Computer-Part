using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SubDevicesButton : MonoBehaviour
{
    public TMP_Text ButtonHeader;
    public Image ButtonImage;
    public Button Button;

    public void SetDevice(string deviceName, Sprite deviceImage, UnityAction onButtonClicked)
    {
        ButtonHeader.text = deviceName;
        ButtonImage.sprite = deviceImage;
        Button.onClick.AddListener(onButtonClicked);
    }
}