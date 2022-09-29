using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public ComputerPartsCollection ComputerPartsCollection;

    [Header("Sub Devices")] 
    public GameObject SubDevicePanel;
    public TMP_Text DeviceName;
    public Transform SubDeviceHolder;
    public SubDevicesButton SubDeviceButton;

    [Header("Parts Panel")]
    public GameObject PartsPanel;
    public Image PartImage;
    public TMP_Text PartHeader;
    public TMP_Text PartName;
    public Button DescriptionButton;

    public GameObject DescriptionPanel;
    public TMP_Text PartDescription;

    public void OpenSystemUnitPanel()
    {
        DeviceName.text = "System Unit";
        foreach (Transform child in SubDeviceHolder) Object.Destroy(child.gameObject);

        SubDevicePanel.SetActive(true);
        for (int i = 0; i < ComputerPartsCollection.SystemUnit.Count; i++)
        {
            SubDevicesButton subDeviceButton = Instantiate(SubDeviceButton, SubDeviceHolder);
            int temp = i;
            subDeviceButton.SetDevice(ComputerPartsCollection.SystemUnit[temp].DeviceName , ComputerPartsCollection.SystemUnit[temp].DeviceImg , () => OpenPart(ComputerPartsCollection.SystemUnit[temp].Device));
        }
    }
    public void OpenOutputDevicesPanel()
    {
        DeviceName.text = "Output Devices";
        foreach (Transform child in SubDeviceHolder) Object.Destroy(child.gameObject);

        SubDevicePanel.SetActive(true);
        for (int i = 0; i < ComputerPartsCollection.OutputDevices.Count; i++)
        {
            SubDevicesButton subDeviceButton = Instantiate(SubDeviceButton, SubDeviceHolder);
            int temp = i;
            subDeviceButton.SetDevice(ComputerPartsCollection.OutputDevices[temp].DeviceName , ComputerPartsCollection.OutputDevices[temp].DeviceImg , () => OpenPart(ComputerPartsCollection.OutputDevices[temp].Device));
        }
    }
    
    public void OpenInputDevicesPanel()
    {
        DeviceName.text = "Input Devices";
        foreach (Transform child in SubDeviceHolder) Object.Destroy(child.gameObject);
        
        SubDevicePanel.SetActive(true);
        for (int i = 0; i < ComputerPartsCollection.InputDevices.Count; i++)
        {
            SubDevicesButton subDeviceButton = Instantiate(SubDeviceButton, SubDeviceHolder);
            int temp = i;
            subDeviceButton.SetDevice(ComputerPartsCollection.InputDevices[temp].DeviceName , ComputerPartsCollection.InputDevices[temp].DeviceImg , () => OpenPart(ComputerPartsCollection.InputDevices[temp].Device));
        }
    }
    
    public void OpenStorageDevicesPanel()
    {
        DeviceName.text = "Storage Devices";
        foreach (Transform child in SubDeviceHolder) Object.Destroy(child.gameObject);
        
        SubDevicePanel.SetActive(true);
        for (int i = 0; i < ComputerPartsCollection.StorageDevices.Count; i++)
        {
            SubDevicesButton subDeviceButton = Instantiate(SubDeviceButton, SubDeviceHolder);
            int temp = i;
            subDeviceButton.SetDevice(ComputerPartsCollection.StorageDevices[temp].DeviceName , ComputerPartsCollection.StorageDevices[temp].DeviceImg , () => OpenPart(ComputerPartsCollection.StorageDevices[temp].Device)); ;
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
