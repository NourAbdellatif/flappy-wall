using UnityEngine;

namespace DefaultNamespace
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class WallScript : MonoBehaviour
    {
        private Rigidbody2D rb;
        [Header("Speed of the wall")]
        [SerializeField]
        public float speed = 3;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        private void OnEnable()
        {
            rb.velocity = new Vector2(-speed, 0);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Destroyer") || other.CompareTag("Player"))
            {
                ObjectPooler.Instance.ReturnToPool(gameObject);
            }
        }
    }
}