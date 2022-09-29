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
            subDeviceButton.SetDevice(ComputerPartsCollection.InputDevices[temp].DeviceName , ComputerPartsCollection.InputDevices[temp].DeviceImg , 
                () =>
                {
                    PartsPanel.SetActive(true);
                    for (int a = 0; a < ComputerPartsCollection.InputDevices.Count; a++)
                    {
                        if (ComputerPartsCollection.InputDevices[a].Device == ComputerPartsCollection.InputDevices[temp].Device)
                        {
                            PartHeader.text = ComputerPartsCollection.InputDevices[a].DeviceName;
                            PartImage.sprite = ComputerPartsCollection.InputDevices[a].DeviceImg;
                            int temp1 = a;
                            DescriptionButton.onClick.AddListener(() =>
                            {
                                DescriptionPanel.SetActive(true);
                                PartName.text = ComputerPartsCollection.InputDevices[temp1].DeviceName;
                                PartDescription.text = ComputerPartsCollection.InputDevices[temp1].DeviceDescription;
                            });
                        }
                    }
                }
            );
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
            subDeviceButton.SetDevice(ComputerPartsCollection.SystemUnit[temp].DeviceName,
                ComputerPartsCollection.SystemUnit[temp].DeviceImg,
                () =>
                {
                    PartsPanel.SetActive(true);
                    for (int a = 0; a < ComputerPartsCollection.SystemUnit.Count; a++)
                    {
                        if (ComputerPartsCollection.SystemUnit[a].Device == ComputerPartsCollection.SystemUnit[temp].Device)
                        {
                            PartHeader.text = ComputerPartsCollection.SystemUnit[a].DeviceName;
                            PartImage.sprite = ComputerPartsCollection.SystemUnit[a].DeviceImg;
                            int temp1 = a;
                            DescriptionButton.onClick.AddListener(() =>
                            {
                                DescriptionPanel.SetActive(true);
                                PartName.text = ComputerPartsCollection.SystemUnit[temp1].DeviceName;
                                PartDescription.text = ComputerPartsCollection.SystemUnit[temp1].DeviceDescription;
                            });
                        }
                    }
                }
            );
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
            subDeviceButton.SetDevice(ComputerPartsCollection.StorageDevices[temp].DeviceName , ComputerPartsCollection.StorageDevices[temp].DeviceImg , 
                () =>
                {
                    PartsPanel.SetActive(true);
                    for (int a = 0; a < ComputerPartsCollection.StorageDevices.Count; a++)
                    {
                        if (ComputerPartsCollection.StorageDevices[a].Device == ComputerPartsCollection.StorageDevices[temp].Device)
                        {
                            PartHeader.text = ComputerPartsCollection.StorageDevices[a].DeviceName;
                            PartImage.sprite = ComputerPartsCollection.StorageDevices[a].DeviceImg;
                            int temp1 = a;
                            DescriptionButton.onClick.AddListener(() =>
                            {
                                DescriptionPanel.SetActive(true);
                                PartName.text = ComputerPartsCollection.StorageDevices[temp1].DeviceName;
                                PartDescription.text = ComputerPartsCollection.StorageDevices[temp1].DeviceDescription;
                            });
                        }
                    }
                }
            ); 
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
            subDeviceButton.SetDevice(ComputerPartsCollection.OutputDevices[temp].DeviceName , ComputerPartsCollection.OutputDevices[temp].DeviceImg , 
                () =>
                {
                    PartsPanel.SetActive(true);
                    for (int a = 0; a < ComputerPartsCollection.OutputDevices.Count; a++)
                    {
                        if (ComputerPartsCollection.OutputDevices[a].Device == ComputerPartsCollection.OutputDevices[temp].Device)
                        {
                            PartHeader.text = ComputerPartsCollection.OutputDevices[a].DeviceName;
                            PartImage.sprite = ComputerPartsCollection.OutputDevices[a].DeviceImg;
                            int temp1 = a;
                            DescriptionButton.onClick.AddListener(() =>
                            {
                                DescriptionPanel.SetActive(true);
                                PartName.text = ComputerPartsCollection.OutputDevices[temp1].DeviceName;
                                PartDescription.text = ComputerPartsCollection.OutputDevices[temp1].DeviceDescription;
                            });
                        }
                    }
                }
            );
        }
    }
}
