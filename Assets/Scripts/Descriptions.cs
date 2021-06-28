using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Descriptions : MonoBehaviour
{
    [SerializeField] TextMeshPro TextField;
    public string gerText, engText;
    public Language language;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (language.isGerman == true)
        {
            TextField.SetText(gerText);
        }
        else if (language.isGerman == false)
        {
            TextField.SetText(engText);
        }
    }
}