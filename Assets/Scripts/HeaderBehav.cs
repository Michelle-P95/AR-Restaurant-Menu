using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeaderBehav : MonoBehaviour
{
    public GameObject germanText;
    public GameObject englishText;
    public bool isGerman;
    // Start is called before the first frame update
    void Start()
    {
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
            germanText.SetActive(true);
            englishText.SetActive(false);
            isGerman = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
