using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private ParticleSystem Confetti;
    private BoxCollider2D boxCollider;
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            boxCollider.enabled = false;
            Confetti.Play();
        }
    }
}
