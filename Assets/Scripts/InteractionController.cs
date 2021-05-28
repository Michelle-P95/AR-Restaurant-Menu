using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Random = UnityEngine.Random;

public class InteractionController : MonoBehaviour
{
    private VideoPlayer vp;
    
    private void Start()
    {
        vp = GetComponent<VideoPlayer>();
    }
    
    
    private void OnMouseDown()
    {
        // --- Random gibt Unity & CShapr - nimm system
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    
    }

    private void OnMouseDrag()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit[] hits = Physics.RaycastAll(ray);

        // was hab ich getroffen   -> finde im array, schnapp 1 element - dessen tag diesem tag entspricht -davon will ich den punkt
        Vector3 hitPoint = Array.Find(hits, element => element.transform.CompareTag("PlaneToMove")).point;
        // --- Array Unity benutzen! nicht array system


        // wenn es 1 position gibt - also ungleich null !!!! null bei vector geht nicht! - darum ZERO
        if (hitPoint != Vector3.zero)
        {
            // vom wuerfel                              // um wuerfuel 0,5 nach oben WEIL im boden war
            transform.position = hitPoint + new Vector3(0, transform.localScale.y * 0.5f, 0);
        }
    }

    public void ToggleVideo()
    {
        if (!vp) return;

        if (vp.isPlaying)
            vp.Pause();
    
        else
            vp.Play();
        
    }

    public void Rotate()
    {
        transform.Rotate(Vector3.up, 45);
    }

    public void Update() 
    {
     // jedes frame 

        // if (Input.GetMouseButtonDown(0)){
        // }

    }
}
