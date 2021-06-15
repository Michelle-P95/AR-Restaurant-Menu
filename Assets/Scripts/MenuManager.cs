using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Vuforia;

public class MenuManager : MonoBehaviour
{
    string gericht;
    public GameObject description;
    public GameObject virtualButtonBeschreibung;
    public GameObject virtualButtonBestellung;
    String lastGericht;


    // Start is called before the first frame update
    void Start()
    {
        virtualButtonBeschreibung = GameObject.Find("Button_Desciption");
        virtualButtonBestellung = GameObject.Find("Button_Bestellen");

        virtualButtonBeschreibung.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(Info);
        virtualButtonBestellung.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(Bestellen);

        virtualButtonBeschreibung.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(InfoReleased);
        virtualButtonBestellung.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(BestellenReleased);

        GameObject.Find("DescriptionBurger").SetActive(false); 
        GameObject.Find("DescriptionPizza").SetActive(false); 
        GameObject.Find("DescriptionHotdog").SetActive(false);
        GameObject.Find("DescriptionPommes").SetActive(false);


    }

    public void Bestellen(VirtualButtonBehaviour obj)
    {
        Debug.Log("+/Bestellen - Button pressed");
        GameObject.Find("DescriptionPizza").SetActive(false);
        if (GameObject.Find("Pizza").activeSelf == true) { GameObject.Find("DescriptionPizza").SetActive(true); }
        GameObject.Find("DescriptionHotdog").SetActive(false);
        if (GameObject.Find("Hotdog").activeSelf == true) { GameObject.Find("DescriptionHotdog").SetActive(true); }
        GameObject.Find("DescriptionBurger").SetActive(false);
        if (GameObject.Find("Burger").activeSelf == true) { GameObject.Find("DescriptionBurger").SetActive(true); }
        GameObject.Find("DescriptionPommes").SetActive(false);
        if (GameObject.Find("Pmmes").activeSelf == true) { GameObject.Find("DescriptionPommes").SetActive(true); }
    }

    public void BestellenReleased(VirtualButtonBehaviour vb) 
    {
        if (GameObject.Find("Burger").activeSelf != false) { GameObject.Find("DescriptionBurger").SetActive(false); }
        if (GameObject.Find("Pizza").activeSelf != false) { GameObject.Find("DescriptionPizza").SetActive(false); }
        if (GameObject.Find("Hotdog").activeSelf != false) { GameObject.Find("DescriptionHotdog").SetActive(false); }
        if (GameObject.Find("Pommes").activeSelf != false) { GameObject.Find("DescriptionPommes").SetActive(false); }
        Debug.Log("+/Bestellen - Button released");
    }

    public void Info(VirtualButtonBehaviour obj)
    {
        Debug.Log("Info - Button pressed");
        //description = GameObject.Find("description" + mySpeisekarte.lastGericht.GetComponent<String>());
        description = GameObject.Find("DescriptionPizza");
        description.SetActive(true);

    }

    public void InfoReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Info - Button released");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
