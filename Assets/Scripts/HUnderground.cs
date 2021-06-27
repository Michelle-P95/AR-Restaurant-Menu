using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUnderground : MonoBehaviour
{
    public Language language;
    public GameObject underground;
    // Start is called before the first frame update
    void Start()
    {
        underground.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (language.isGerman == true)
        {
            underground.SetActive(false);
        }
        else if (language.isGerman == false)
        {
            underground.SetActive(true);
        }
    }
}
