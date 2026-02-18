using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BasicMarkerHandler : AudioTimelineMarkerHandler
{
    //object to manipulate in response, we can move it, manipulate it, trigger an anim, whatever
    [SerializeField] Transform ObjectToHandle;



    private void Start()
    {
        
    }

    public override void HandleIt(bool onoff)
    {
        Debug.Log(transform.name + " Handled It!! " + onoff);
        bounce(onoff);  //anything you want
    }

    public void bounce(bool onoff)
    {
        Debug.Log("bounce " + onoff);
        if(onoff)
        {
            transform.position += Vector3.up * 2;
        }
        else
        {
            transform.position += Vector3.down * 2;
        }
    }

    

    public FMODUnity.StudioEventEmitter getEmmitter()
    {
        return ObjectToHandle.GetComponent<FMODUnity.StudioEventEmitter>();
    }
}
