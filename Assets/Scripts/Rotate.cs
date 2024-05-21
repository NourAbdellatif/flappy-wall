using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    public Rigidbody2D rb;
    public bool reverse = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.angularVelocity = speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("Angular velocity" + rb.angularVelocity);
        rb.angularVelocity = reverse ? -speed : speed;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            reverse = !reverse;
        }
    }
}
