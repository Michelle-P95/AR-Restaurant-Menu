using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DishOption : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI optionTextField;
    public int MAXIMUM = 3;
    public int MINIMUM = 0; // will be set to 0 if < 0 trough Unity
    public string fullText;

    private string text;
    private int current = 1;

    void Start()
    {
        if(MINIMUM < 0) {
            MINIMUM = 0;
        }
        text = optionTextField.text;
        fullText = current + "x " + text;
        optionTextField.SetText(fullText);
    }

    public void add()
    {
        if (current < MAXIMUM)
        {
            current++;
            fullText = current + "x " + text;
            optionTextField.SetText(fullText); 
        }
    }

    public void substract()
    {
        if (current > MINIMUM)
        {
            current--;            
            fullText = current + "x " + text;
            optionTextField.SetText(fullText);
        }
    }
}
