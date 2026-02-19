using UnityEngine;

public class Inventory : MonoBehaviour
{

    public GameObject[] stuff;
    private int nextSlot = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool Add(GameObject obj)
    {
        for(int i = 0;i <stuff.Length; i++)
        {
            if(obj == stuff[i])
            {
                //i'm already here
                Debug.Log("i'm already here " + obj.name);
                return false;
            }

        }

        if(nextSlot < stuff.Length)
        {
            stuff[nextSlot] = obj;
            nextSlot++;
            return true;
        }
        else
        {
            Debug.Log("no slots");
            return false;
        }
        
    }
}
