using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Vuforia;

public class MenuManager : MonoBehaviour
{
    string gericht;
    //public MenuManager mMenumanager;
    //public GameObject Speisekarte;
    //private Speisekarte mySpeisekarte;
    public GameObject description;
    public GameObject virtualButtonBeschreibung;
    public GameObject virtualButtonBestellung;
    String lastGericht;


    // Start is called before the first frame update
    void Start()
    {

        //mySpeisekarte = Speisekarte.GetComponent<Speisekarte>();
        virtualButtonBeschreibung = GameObject.Find("Button_Desciption");
        virtualButtonBestellung = GameObject.Find("Button_Bestellen");

        virtualButtonBeschreibung.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(Info);
        virtualButtonBestellung.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(Bestellen);

        virtualButtonBeschreibung.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(InfoReleased);
        virtualButtonBestellung.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(BestellenReleased);

        //description = GameObject.Find("description" + mySpeisekarte.lastGericht.GetComponent<String>());
        description = GameObject.Find("DescriptionPizza");
        description.SetActive(false);

    }

    public void Bestellen(VirtualButtonBehaviour obj)
    {
        Debug.Log("+/Bestellen - Button pressed");
        
    }

    public void BestellenReleased(VirtualButtonBehaviour vb) 
    {
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
        //mySpeisekarte = Speisekarte.GetComponent<Speisekarte>();
        
    }
}
