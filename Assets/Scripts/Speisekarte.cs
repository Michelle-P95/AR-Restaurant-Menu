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
    public Animator blackBackgroundAnimator;
    public ActiveDishKeeper activeDishKeeper;

    private GameObject description;
    private Boolean dishActive;
    private Transform backButtonPosition;
    private Transform originalButtonPosition;

    // Start is called before the first frame update
    void Start()
    {
        virtualButton = GameObject.Find("VirtualButton_" + gericht);
        description = GameObject.Find(gericht + "_Description");
        textplanes = description.GetComponent<TextPlanes>();
        backButtonPosition = GameObject.Find("BackButtonPosition").transform;
        originalButtonPosition = virtualButton.transform;

        virtualButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        virtualButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        
        gericht3Dmodel.SetActive(false);
        blackBackground.SetActive(false);
        description.SetActive(false);
        dishActive = false;
    }
    // Methoden wenn VirtualButton mit finger getriggert wird
    private void OnButtonPressed(VirtualButtonBehaviour obj)
    {
        if (dishActive)
        { // DEACTIVATE
            blackBackgroundAnimator.SetBool("dishActive", false);
            StartCoroutine(waitBeforeClosingBackground());
            description.SetActive(false);
            gericht3Dmodel.SetActive(false);
            dishActive = false;
            activeDishKeeper.dishActive = dishActive;
            activeDishKeeper.activeDishName = "";
            activateDeactivateOtherButtons();
        }
        else
        {
            if (virtualButton.activeSelf)
            { // ACTIVATE
                gericht3Dmodel.SetActive(true);
                blackBackground.SetActive(true);
                blackBackgroundAnimator.SetBool("dishActive", true);
                description.SetActive(true);
                dishActive = true;
                activeDishKeeper.dishActive = dishActive;
                activeDishKeeper.activeDishName = gericht3Dmodel.name;
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

    //  only called to wait for a second before deactivating the background, so the animation has time to finish
    private IEnumerator waitBeforeClosingBackground()
    {
        yield return new WaitForSeconds(1);
        blackBackground.SetActive(false);
    }
}