
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float speed = 15;
    private float xBounds = 9.5f;
    public GameObject projectilePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        if (transform.position.x > xBounds)
        {
            transform.position = new Vector3(xBounds, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xBounds)
        {
            transform.position = new Vector3(-xBounds, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 spawnPos = new Vector3(transform.position.x, 1.5f, transform.position.z);
            Instantiate(projectilePrefab, spawnPos, projectilePrefab.transform.rotation);
        }
    }
}
