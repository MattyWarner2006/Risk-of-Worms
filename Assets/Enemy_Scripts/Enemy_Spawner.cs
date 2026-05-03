using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy_Spawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnArea;

     void Start()
     {
         SpawnEnemy();
         StartCoroutine(EnemySpawner());
     }

    public IEnumerator EnemySpawner()
    {
        yield return new WaitForSeconds(2);
        SpawnEnemy();
        StartCoroutine(EnemySpawner());
    }

    public void SpawnEnemy()
    {
        GameObject spawnedEnemy = Instantiate(enemy, spawnArea[Random.Range(0, spawnArea.Length)].position,Quaternion.identity);
        spawnedEnemy.SetActive(true);
    }
}
