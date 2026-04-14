using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public float minSize = 0.5f;
    public float maxSize = 2.0f;
    public float minSpeed = 100f;
    public float maxSpeed = 400f;
    public float maxSpinSpeed = 10f;
    Rigidbody2D rb;
    
    void Start()
    {
        float randomSize = Random.Range(minSize, maxSize);
        float randomSpeed = Random.Range(minSpeed, maxSpeed)/randomSize;
        Vector2 randomDirection = Random.insideUnitCircle;
        float randomTorque = Random.Range(-maxSpinSpeed, maxSpinSpeed);
        rb = GetComponent<Rigidbody2D>();

        transform.localScale = new Vector3(randomSize, randomSize, 1);

        rb.AddForce(randomDirection * randomSpeed);
        rb.AddTorque(randomTorque);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
