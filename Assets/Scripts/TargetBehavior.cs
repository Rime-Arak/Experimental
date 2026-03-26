using UnityEngine;

public class TargetBehavior : MonoBehaviour
{
    private float speed = 10;
    private float xBounds = 9.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (transform.position.x > xBounds || transform.position.x < -xBounds)
        {
            speed = -speed;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("projectile"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
