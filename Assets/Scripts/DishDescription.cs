using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishDescription : MonoBehaviour
{

    private bool isGerman;
    public string germanDes, engDes;
    public Language language;
    void Start()
    {
        isGerman = true;
    }

    // Update is called once per frame
    void Update()
    {
        isGerman = language.isGerman;
        if(isGerman) {
            renderGerman();
        } else {
            renderEng();
        }
    }

    private void renderGerman() {
        
    }

    private void renderEng() {

    }

}
