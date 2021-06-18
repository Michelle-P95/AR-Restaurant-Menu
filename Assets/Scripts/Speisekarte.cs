using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Speisekarte : MonoBehaviour
{
    public String gericht;
    public GameObject gericht3Dmodel;
    public GameObject virtualButton;
    public GameObject[] otherDishButtons;
    public GameObject blackBackground;

    private GameObject description;
    private Boolean dishActive;
    private Transform backButtonPosition;
    private Transform originalButtonPosition;
    private Animation fadeIn, fadeOut;

    // Start is called before the first frame update
    void Start()
    {
        virtualButton = GameObject.Find("VirtualButton_" + gericht);
        description = GameObject.Find(gericht + "_Description");
        backButtonPosition = GameObject.Find("BackButtonPosition").transform;
        originalButtonPosition = virtualButton.transform;

        virtualButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        virtualButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        gericht3Dmodel.SetActive(false);
        blackBackground.SetActive(false);
        fadeIn = blackBackground.GetComponent<Animation>();
        description.SetActive(false);
        dishActive = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Methoden wenn VirtualButton mit finger getriggert wird
    private void OnButtonPressed(VirtualButtonBehaviour obj)
    {
        if (dishActive)
        {
            gericht3Dmodel.SetActive(false);
            blackBackground.SetActive(false);
            description.SetActive(false);
            dishActive = false;
            // changeButtonPosition();
            activateDeactivateOtherButtons();
        }
        else
        {
            if (virtualButton.activeSelf)
            {
                gericht3Dmodel.SetActive(true);
                blackBackground.SetActive(true);
                fadeIn.Play();
                description.SetActive(true);
                dishActive = true;
                // changeButtonPosition();
                activateDeactivateOtherButtons();
            }
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        // Debug.Log("Button released");

    }

    private void activateDeactivateOtherButtons()
    {
        if (dishActive)
        {
            for (int i = 0; i < otherDishButtons.Length; i++)
            {
                otherDishButtons[i].SetActive(false);
            }
        }
        else
        {
            for (int i = 0; i < otherDishButtons.Length; i++)
            {
                otherDishButtons[i].SetActive(true);
            }
        }
    }

    // TODO: funktioniert noch nicht (Buttons bleiben an falscher Position bestehen)
    // um aktiven Button des Gerichts rechts neben das 3d Model zu bewegen wenn Gericht aktiv
    // bei Deaktivierung wird Btn wieder zurück an Originalposition gesetzt
    private void changeButtonPosition()
    {
        if (dishActive)
        {
            virtualButton.transform.position = backButtonPosition.position;
        }
        else
        {
            virtualButton.transform.position = originalButtonPosition.position;
        }
    }
}