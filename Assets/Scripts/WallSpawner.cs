using System.Collections;
using DefaultNamespace;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject wallPrefab;

    [SerializeField]
    public float spawnRate = 2f;

    private IEnumerator spawnCoroutine()
    {
        while (true)
        {
            SpawnWall();
            yield return new WaitForSeconds(Random.Range(spawnRate, spawnRate + 1f));
        }
    }
    void Start()
    {
        StartCoroutine(spawnCoroutine());
    }

    public void SpawnWall()
    {
        Debug.Log(ObjectPooler.Instance);
        ObjectPooler.Instance.SpawnFromPool("Wall", new Vector3(10, Random.Range(-3f, 3f), 0), Quaternion.identity);
    }
}
