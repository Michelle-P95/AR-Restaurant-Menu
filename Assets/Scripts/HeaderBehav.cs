using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HeaderBehav : MonoBehaviour
{
    [SerializeField] GameObject header;
    public Language language;
    // Start is called before the first frame update
    void Start()
    {
        header.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (language.isGerman == true)
        {
            header.SetActive(false);
        }
        else if (language.isGerman == false)
        {
            header.SetActive(true);
        }

    }
}