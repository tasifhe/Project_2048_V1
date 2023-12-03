using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fill2048Comp : MonoBehaviour
{
    int value;
    [SerializeField] TextMeshProUGUI valueDisplay;
    
    public void FillValueUpdate(int valueIn)
    {
        value = valueIn;
        valueDisplay.text = value.ToString();
    }
}
