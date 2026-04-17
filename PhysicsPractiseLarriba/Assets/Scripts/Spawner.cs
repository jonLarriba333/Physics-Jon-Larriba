using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject robot;
    public int positionx = 0;

    private Quaternion q;
    private Vector3 v3 = Vector3.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        q = new Quaternion(0, 0, 0, 0); 
        v3 = new Vector3(positionx, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Object.Instantiate(robot, v3, q);
        v3.z = v3.z + 1;
    }
}
