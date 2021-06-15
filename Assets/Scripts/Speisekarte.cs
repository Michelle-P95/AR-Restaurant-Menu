using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class Speisekarte : MonoBehaviour
{
    public Speisekarte mSpeisekarte;
    public String gericht;
    public GameObject gericht3Dmodel;
    public GameObject virtualButton;
    public GameObject lastGericht;


    // Start is called before the first frame update
    void Start()
    {
        virtualButton = GameObject.Find("VirtualButton_" + gericht);

        virtualButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        virtualButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        gericht3Dmodel.SetActive(false);
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Methoden wenn VirtualButton mit finger getriggert wird
    private void OnButtonPressed(VirtualButtonBehaviour obj)
    {
        Debug.Log(gericht + " - Button pressed");

        gericht3Dmodel.SetActive(true);

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button released");
        if (gericht3Dmodel != GameObject.Find("Burger")) { GameObject.Find("Burger").SetActive(false); }
        if (gericht3Dmodel != GameObject.Find("Pizza")) { GameObject.Find("Pizza").SetActive(false); }
        if (gericht3Dmodel != GameObject.Find("Hotdog")) { GameObject.Find("Hotdog").SetActive(false); }
        if (gericht3Dmodel != GameObject.Find("Pommes")) { GameObject.Find("Pommes").SetActive(false); }
    }

    public void turnOff()
    {
        gericht3Dmodel.SetActive(false);
    }

    public void getLast()
    {
            
    }

}