using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float timeLeft = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("killable"))
        {
            Debug.Log("Collission Entered");
            Destroy(collision.gameObject);
        }
    }


}
