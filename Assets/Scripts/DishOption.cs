using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DishOption : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI optionTextField;
    public string eng, ger;
    public Language language;
    public int MAXIMUM = 3;
    public int MINIMUM = 0; // will be set to 0 if < 0 trough Unity
    public string fullText;

    private string text;
    private int current = 1;
    public bool scriptForBestellDone;

    void Start()
    {
        

        if (MINIMUM < 0) {
            MINIMUM = 0;
        }
        text = ger;
        if (scriptForBestellDone) fullText = text;
        else fullText = current + "x " + text;
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

    public void Update()
    {
        if (language.isGerman == true)
        {
            text = ger;
            fullText = current + "x " + text;
            if (scriptForBestellDone) fullText = text;
            optionTextField.SetText(fullText);
        }
        else if (language.isGerman == false)
        {
            text = eng;
            fullText = current + "x " + text;
            if (scriptForBestellDone) fullText = text;
            optionTextField.SetText(fullText);
            
        }
    }
}
