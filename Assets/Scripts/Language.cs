using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Language : MonoBehaviour
{

    public bool isGerman;

    // Start is called before the first frame update
    void Start()
    {
        isGerman=true;
    }

    public void changeLang()
    {
        if (isGerman == true) { isGerman = false; }
        else { isGerman = true; }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
