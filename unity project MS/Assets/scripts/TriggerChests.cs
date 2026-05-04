using UnityEngine;

public class TriggerChests : MonoBehaviour
{
    // To pole pojawi się w Inspectorze - przeciągnij tu Audio Source z dźwiękiem znajdźki
    public AudioSource pickupSound;

    void Start()
    {
        // Start zostawiamy pusty, bo nie musimy już szukać komponentu automatycznie
    }

    private void OnTriggerEnter2D(Collider2D playerCollision)
    {
        // Sprawdzamy, czy obiekt, w który wjechaliśmy, ma tag "collectibles"
        if (playerCollision.CompareTag("collectibles"))
        {
            // Odtwarzamy przypisany dźwięk zbierania
            if (pickupSound != null)
            {
                pickupSound.Play();
            }

            // Usuwamy ze sceny zebraną znajdźkę
            Destroy(playerCollision.gameObject);
        }
    }
}