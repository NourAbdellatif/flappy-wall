using UnityEngine;

namespace DefaultNamespace
{
    public class ObjectPooler : MonoBehaviour
    {
        public static ObjectPooler Instance;
        public GameObject wallPrefab = null;
        public static int poolSize = 15;
        public static GameObject[] pool;
        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(this);
            }
            else if (Instance == null)
            {
                Instance = this;
            }
        }

        private void Start()
        {
            pool = new GameObject[poolSize];
            for (int i = 0; i < poolSize; i++)
            {
                pool[i] = Instantiate(wallPrefab, new Vector3(0, 0, 0), Quaternion.identity);
                pool[i].SetActive(false);
            }
        }

        public GameObject SpawnFromPool(string tag, Vector3 position, Quaternion rotation)
        {

            for (int i = 0; i < poolSize; i++)
            {
                if (!pool[i].activeInHierarchy && pool[i].tag == tag)
                {
                    pool[i].SetActive(true);
                    pool[i].transform.position = position;
                    pool[i].transform.rotation = rotation;
                    return pool[i];
                }
            }

            return null;
        }

        public void ReturnToPool(GameObject o)
        {
            o.SetActive(false);
        }
    }
}