using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
                                  // hiervon Erben
public class TrackableHandler : DefaultTrackableEventHandler
{
    private VideoPlayer player;
    
    // Start is called before the first frame update
    protected override void Start()
    {
        // base. =  erbe von Superclass methode
        base.Start();

        player = GetComponentInChildren<VideoPlayer>();
    }

    // onTrackingFound   &  onTrackingLost  von Default nehmen
    protected override void OnTrackingFound()
    {
        // benutze funktionen-mit (wie zb das objekte unsichtbar werden)
        base.OnTrackingFound();
        // wenn player gefunden getracked -> in getracket methode
        if (player)
             player.Play();
    }
    
    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        // wenn player gelostet -> in gelost methode
        if (player)
             player.Stop();
    }

    
}
