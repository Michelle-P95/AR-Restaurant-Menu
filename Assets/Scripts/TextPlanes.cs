using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextPlanes : MonoBehaviour
{
    public GameObject germanText;
    public GameObject englishText;
    public GameObject Layer;
    public string text;
    public bool isGerman;
    // Start is called before the first frame update
    void Start()
    {

        text = Layer.name;
        englishText.SetActive(false);
        germanText.SetActive(true);
        isGerman = true;
    }

    public void changeLang() 
    {
        if (isGerman == true)
        {
            germanText.SetActive(false);
            englishText.SetActive(true);
            isGerman = false;
        }
        else if (isGerman == false) 
        {
            englishText.SetActive(false);
            germanText.SetActive(true);
            isGerman = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
