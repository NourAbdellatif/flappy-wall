using UnityEngine;

namespace DefaultNamespace
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class WallScript : MonoBehaviour
    {
        private Rigidbody2D rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(-3, 0);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Destroyer") || other.CompareTag("Player"))
            {
                Destroy(gameObject);
            }
        }
    }
}