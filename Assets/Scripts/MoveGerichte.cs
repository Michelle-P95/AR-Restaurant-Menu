using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGerichte : MonoBehaviour
{
    public float speed = 5f;
    public string rotationDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotationDirection == "links" | rotationDirection == "L")
        {
            transform.rotation *= Quaternion.Euler(0, -speed, 0);

        }
        else if (rotationDirection == "rechts" | rotationDirection == "R")
        {
            transform.rotation *= Quaternion.Euler(0, speed, 0);
        }

        else
        {
            Debug.Log("Fehler Rotations Direction - L oder R angeben");
        }

        
    }

        

}
