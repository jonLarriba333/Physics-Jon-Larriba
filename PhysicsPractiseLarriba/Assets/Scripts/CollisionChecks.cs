using UnityEngine;

public class CollisionChecks : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void onCollissionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Capsule")
        {
            Debug.Log("Collission Entered");
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Capsule")
        {
            Debug.Log("Inside the collision");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Capsule")
        {
            Debug.Log("Collision exited");
        }
    }
}
