using UnityEngine;

public class TrigCollide : BasicCollide
{

    public GameObject ObjOfInterest;
    
    
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

        Debug.Log("Handle Enter " + transform.name + " " + otherTransform.name);

        ObjOfInterest.SetActive(true);
    }
    public override void HandleTriggerExit(Transform otherTransform)
    {

        Debug.Log("Handle Exit " + transform.name + " " + otherTransform.name);

        ObjOfInterest.SetActive(false);
    }
}
