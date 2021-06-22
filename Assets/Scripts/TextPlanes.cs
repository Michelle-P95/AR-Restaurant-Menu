using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextPlanes : MonoBehaviour
{
    public GameObject germanText;
    public GameObject englishText;
    public bool isGerman;
    public bool isOn;
    public GameObject activeText;
    // Start is called before the first frame update
    void Start()
    {
        goOff();
    }

    public void changeLang()
    {
        if (isGerman == true)
        {
            activeText = englishText;
            isGerman = false;
        }
        else if (isGerman == false)
        {
            activeText = germanText;
            isGerman = true;
        }
    }

    public void goOn()
    {
        isOn = true;
    }

    public void goOff() 
    {
        isOn = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (isOn == true)
        {
            activeText.SetActive(true);
        }
        else if (isOn == false)
        {
            activeText.SetActive(false);
        }
    }
}
