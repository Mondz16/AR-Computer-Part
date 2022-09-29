using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ComputerPartsCollection" , fileName = "ComputerPartsCollection")]
public class ComputerPartsCollection : ScriptableObject
{
    public List<ComputerPart> SystemUnit;
    public List<ComputerPart> InputDevices;
    public List<ComputerPart> StorageDevices;
    public List<ComputerPart> OutputDevices;
}

[System.Serializable]
public class ComputerPart
{
    public Device Device;
    public string DeviceName;
    public Sprite DeviceImg;
    [TextArea] public string DeviceDescription;
}

public enum Device {
    //System Unit
    Motherboard, PowerSupply, Processor, RAM
}