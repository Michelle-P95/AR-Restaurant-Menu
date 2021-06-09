using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    string gericht;
    public GameObject description;
    public GameObject virtualButtonBeschreibung;
    public GameObject virtualButtonBestellung;

    // Start is called before the first frame update
    void Start()
    {
        

        virtualButtonBeschreibung = GameObject.Find("Button_Desciption");
        virtualButtonBestellung = GameObject.Find("Button_Bestellen");

        virtualButtonBeschreibung.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(Info);
        virtualButtonBestellung.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(Bestellen);


    }

    public void Bestellen(VirtualButtonBehaviour obj)
    {
        Debug.Log("+/Bestellen - Button pressed");
        
    }

    public void Info(VirtualButtonBehaviour obj)
    {
        Debug.Log("Info - Button pressed");
        String lastGericht = Speisekarte.lastGericht.GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        gericht = Speisekarte.gericht;
    }
}
