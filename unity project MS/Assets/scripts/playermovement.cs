using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    private bool isGroundedl;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        float movex = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(movex * moveSpeed, rb.linearVelocity.y);
    }
}
