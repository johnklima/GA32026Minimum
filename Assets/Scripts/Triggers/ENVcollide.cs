using UnityEngine;
using FMODUnity;

public class ENVcollide : BasicCollide
{
    public Transform transAudio;
    public EventEmitterManager manager;
    public int thisParm;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


   
    public override void HandleTriggerEnter(Transform otherTransform)
    {

        Debug.Log("Handle RESET Params " + transform.name + " " + otherTransform.name);
        
        manager.setParms(thisParm);

    }



    public override void HandleTriggerExit(Transform otherTransform)
    {

        Debug.Log("Handle Exit " + transform.name + " " + otherTransform.name);

    }
}
