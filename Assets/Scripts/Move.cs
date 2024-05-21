using System;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;

    [SerializeField]
    private float JumpIntensity = 2;

    void Start()
    {

    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, JumpIntensity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
    }

    // private void FixedUpdate()
    // {
    //     throw new NotImplementedException();
    // }
}
