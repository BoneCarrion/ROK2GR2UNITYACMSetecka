using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public AudioSource rollingSound; // Zmienione na public!
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movex = Input.GetAxis("Horizontal");

        // Ruch kulki
        rb.linearVelocity = new Vector2(movex * moveSpeed, rb.linearVelocity.y);

        // Obsługa dźwięku
        if (Mathf.Abs(movex) > 0.1f)
        {
            if (!rollingSound.isPlaying)
            {
                rollingSound.Play();
            }
        }
        else
        {
            rollingSound.Stop();
        }
    }
}