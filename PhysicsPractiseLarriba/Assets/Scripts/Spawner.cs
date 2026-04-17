using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject robot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Object.Instantiate(robot);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
