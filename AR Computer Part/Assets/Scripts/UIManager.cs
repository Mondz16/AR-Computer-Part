using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public ComputerPartsCollection ComputerPartsCollection;

    [Header("BG nad Header Colors")] 
    public Color[] Colors;
    
    [Header("Main Devices")] 
    public Transform SidePanelTransform;

    [Header("Sub Devices")] 
    public GameObject SubDevicePanel;
    public TMP_Text DeviceName;
    public Image DeviceNameBG;
    public Transform SubDeviceHolder;
    public SubDevicesButton SubDeviceButton;

    [Header("Parts Panel")]
    public GameObject PartsPanel;
    public Image PartImage;
    public TMP_Text PartHeader;
    public Image PartBG;
    public TMP_Text PartName;
    public Button DescriptionButton;

    public GameObject DescriptionPanel;
    public TMP_Text PartDescription;

    public void OpenSideMenu()
    {
        SidePanelTransform.DOMoveX(540, .5f);
    }
    
    public void CloseSideMenu()
    {
        SidePanelTransform.DOMoveX(-540, .5f);
    }
    
    public void OpenInputDevicesPanel()
    {
        DeviceName.text = "Input Devices";
        DeviceNameBG.color = Colors[0];
        PartBG.color = Colors[0];
        foreach (Transform child in SubDeviceHolder) Object.Destroy(child.gameObject);
        
        SubDevicePanel.SetActive(true);
        for (int i = 0; i < ComputerPartsCollection.InputDevices.Count; i++)
        {
            SubDevicesButton subDeviceButton = Instantiate(SubDeviceButton, SubDeviceHolder);
            int temp = i;
            subDeviceButton.SetDevice(ComputerPartsCollection.InputDevices[temp].DeviceName , ComputerPartsCollection.InputDevices[temp].DeviceImg , () => OpenPart(ComputerPartsCollection.InputDevices[temp].Device));
        }
    }
    
    public void OpenSystemUnitPanel()
    {
        DeviceName.text = "System Unit";
        DeviceNameBG.color = Colors[1];
        PartBG.color = Colors[1];
        foreach (Transform child in SubDeviceHolder) Object.Destroy(child.gameObject);

        SubDevicePanel.SetActive(true);
        for (int i = 0; i < ComputerPartsCollection.SystemUnit.Count; i++)
        {
            SubDevicesButton subDeviceButton = Instantiate(SubDeviceButton, SubDeviceHolder);
            int temp = i;
            subDeviceButton.SetDevice(ComputerPartsCollection.SystemUnit[temp].DeviceName , ComputerPartsCollection.SystemUnit[temp].DeviceImg , () => OpenPart(ComputerPartsCollection.SystemUnit[temp].Device));
        }
    }
    
    public void OpenStorageDevicesPanel()
    {
        DeviceName.text = "Storage Devices";
        DeviceNameBG.color = Colors[2];
        PartBG.color = Colors[2];
        foreach (Transform child in SubDeviceHolder) Object.Destroy(child.gameObject);
        
        SubDevicePanel.SetActive(true);
        for (int i = 0; i < ComputerPartsCollection.StorageDevices.Count; i++)
        {
            SubDevicesButton subDeviceButton = Instantiate(SubDeviceButton, SubDeviceHolder);
            int temp = i;
            subDeviceButton.SetDevice(ComputerPartsCollection.StorageDevices[temp].DeviceName , ComputerPartsCollection.StorageDevices[temp].DeviceImg , () => OpenPart(ComputerPartsCollection.StorageDevices[temp].Device)); ;
        }
    }
    
    public void OpenOutputDevicesPanel()
    {
        DeviceName.text = "Output Devices";
        DeviceNameBG.color = Colors[3];
        PartBG.color = Colors[3];
        foreach (Transform child in SubDeviceHolder) Object.Destroy(child.gameObject);

        SubDevicePanel.SetActive(true);
        for (int i = 0; i < ComputerPartsCollection.OutputDevices.Count; i++)
        {
            SubDevicesButton subDeviceButton = Instantiate(SubDeviceButton, SubDeviceHolder);
            int temp = i;
            subDeviceButton.SetDevice(ComputerPartsCollection.OutputDevices[temp].DeviceName , ComputerPartsCollection.OutputDevices[temp].DeviceImg , () => OpenPart(ComputerPartsCollection.OutputDevices[temp].Device));
        }
    }
    
    private void OpenPart(Device device)
    {
        PartsPanel.SetActive(true);
        for (int i = 0; i < ComputerPartsCollection.SystemUnit.Count; i++)
        {
            if (ComputerPartsCollection.SystemUnit[i].Device == device)
            {
                PartHeader.text = ComputerPartsCollection.SystemUnit[i].DeviceName;
                PartImage.sprite = ComputerPartsCollection.SystemUnit[i].DeviceImg;
                int temp = i;
                DescriptionButton.onClick.AddListener(() =>
                {
                    DescriptionPanel.SetActive(true);
                    PartName.text = ComputerPartsCollection.SystemUnit[temp].DeviceName;
                    PartDescription.text = ComputerPartsCollection.SystemUnit[temp].DeviceDescription;
                });
            }
        }
    }
}
