using UnityEngine;

public class TriggerChests : MonoBehaviour
{
    AudioSource audiosource;

    private void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D playerCollision)
    {
        if (playerCollision.CompareTag("collectibles"))
        {
            Destroy(playerCollision.gameObject);
        }
    }

}
