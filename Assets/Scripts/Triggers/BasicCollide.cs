using UnityEngine;

public abstract class BasicCollide : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {

            Debug.Log("player hit " + name);

            //call the concrete implementation
            HandleTriggerEnter(other.transform);

            Inventory inv = other.transform.GetComponent<Inventory>();

            //lets just say all triggers add themselves to the player inventory
            inv.Add(transform.gameObject);


        }
    }

    public abstract void HandleTriggerEnter(Transform otherTransform);
}
