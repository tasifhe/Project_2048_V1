using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Fill2048Comp : MonoBehaviour
{
    public int value;
    [SerializeField] Text valueDisplay;
    [SerializeField] float speed;
    bool hasCombine;
    public void FillValueUpdate(int valueIn)
    {
        value = valueIn;
        valueDisplay.text = value.ToString();
    }
    private void Update()
    {
        if (transform.localPosition != Vector3.zero)
        {
            hasCombine = false;
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, Vector3.zero, speed * Time.deltaTime);
        }
        else if (hasCombine == false)
        {
            if (transform.parent.GetChild(0) != this.transform)
            {
                Destroy(transform.parent.GetChild(0).gameObject);
            }
            hasCombine = true;
        }
    }
    public void Double()
    {
        value *= 2;
        GameControllerComp.instance.ScoreUpdate(value);
        valueDisplay.text = value.ToString();
    }
}