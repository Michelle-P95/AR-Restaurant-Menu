using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTranslateBehav : MonoBehaviour
{
    public void DOSOMETHING()
    {
        FindObjectOfType<TextPlanes>().changeLang();
        FindObjectOfType<HeaderBehav>().changeLang();
    }
}