using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeaderBehav : MonoBehaviour
{
    public GameObject header;
    public Language language;
    // Start is called before the first frame update
    void Start()
    {
        //header = GameObject.Find("Header");
        header.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (language.isGerman == true)
        {
            header.SetActive(true);
        }
        else if (language.isGerman == false)
        {
            header.SetActive(false);
        }

    }
}
