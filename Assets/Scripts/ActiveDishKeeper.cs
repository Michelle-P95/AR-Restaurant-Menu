using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveDishKeeper : MonoBehaviour
{
    public string activeDishName;
    public bool dishActive;

    void Start()
    {
        dishActive = false;
        activeDishName = "";
    }

    void Update()
    {
        
    }
}
