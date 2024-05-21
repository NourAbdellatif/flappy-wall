using System.Collections;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject wallPrefab;

    private IEnumerator spawnCoroutine()
    {
        while (true)
        {
            SpawnWall();
            yield return new WaitForSeconds(Random.Range(2f, 4f));
        }
    }
    void Start()
    {
        StartCoroutine(spawnCoroutine());
    }

    public void SpawnWall()
    {

        Instantiate(wallPrefab, new Vector3(10, Random.Range(-3f, 3f), 0), Quaternion.identity);
    }
}
