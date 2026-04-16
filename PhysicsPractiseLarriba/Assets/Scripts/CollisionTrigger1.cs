using UnityEngine;
using System.Collections;

public class CollisionTrigger1 : MonoBehaviour
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
        if (other.gameObject.name == "Capsule")
        {
            Debug.Log("Collission Entered");
         }
        //Destroy(gameObject);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            Debug.Log("Inside the collision");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            Debug.Log("Collision exited");
            //Destroy(gameObject); This is for destroying the object
        }
    }
}
