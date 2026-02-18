using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class EventEmitterManager : MonoBehaviour
{

    StudioEventEmitter emit;
    private EventInstance eventInstance; // Cache the instance
    public string[] ParamNames = { "ENV0", "ENV1", "ENV2" };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        emit = transform.GetComponent<StudioEventEmitter>();

        // Get the live event instance after it has been created by the emitter (e.g., on Start or Awake)
        eventInstance = emit.EventInstance;
        // Now you can update parameters on this specific instance
        resetParms();


        //Debug.Log("this is root start! " + eventInstance.getParameterByName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void resetParms()
    {
        eventInstance.setParameterByName(ParamNames[0], 0.0f);
        eventInstance.setParameterByName(ParamNames[1], 0.0f);
        eventInstance.setParameterByName(ParamNames[2], 0.0f);
    }
    public void setParms(int i)
    {
        resetParms();
        eventInstance.setParameterByName(ParamNames[i], 1.0f);
    }

}
