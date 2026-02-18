using UnityEngine;
using FMODUnity;

public class ENVcollide : BasicCollide
{
    public Transform transAudio;
    private StudioEventEmitter emit;
    public EventEmitterManager manager;
    public int thisParm;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        emit = transAudio.GetComponent<StudioEventEmitter>();
       
        Debug.Log(emit.name);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(emit.Params.Length);
    }
   
    public override void HandleTriggerEnter(Transform otherTransform)
    {

        Debug.Log("Handle RESET Params " + transform.name + " " + otherTransform.name);
        Debug.Log(emit.name);


        manager.setParms(thisParm);

        //resetParm();
        //emit.SetParameter(emit.Params[thisParm].Name, 0);


    }

    private void resetParm()
    {
        //set all parms to zero
        for (int i= 0; i < emit.Params.Length; i++)
        {
            Debug.Log(emit.Params[i].Name);
            emit.SetParameter(emit.Params[i].Name, 0) ;
        }
        
    }

    public override void HandleTriggerExit(Transform otherTransform)
    {

        Debug.Log("Handle Exit " + transform.name + " " + otherTransform.name);

    }
}
