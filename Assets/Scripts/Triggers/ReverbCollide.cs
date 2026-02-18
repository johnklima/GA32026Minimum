using UnityEngine;
using FMODUnity;
public class ReverbCollide : BasicCollide
{

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public override void HandleTriggerEnter(Transform otherTransform)
    {

        Debug.Log("Handle Enter" + transform.name + " " + otherTransform.name);

    }
    public override void HandleTriggerExit(Transform otherTransform)
    {

        Debug.Log("Handle Exit " + transform.name + " " + otherTransform.name);
        
    }
}
