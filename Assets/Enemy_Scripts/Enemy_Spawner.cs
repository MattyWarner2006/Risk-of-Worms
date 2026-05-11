using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;


public class Enemy_Spawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnArea;

    
    //spawn enemy on game start + start spawner timer
     void Start()
     {
         SpawnEnemy();
         StartCoroutine(EnemySpawner());
     }

     
     //wait inputted time, then spawn enemy
    public IEnumerator EnemySpawner()
    {
        yield return new WaitForSeconds(2);
        SpawnEnemy();
        StartCoroutine(EnemySpawner());
    }

    //spawns new enemy
    public void SpawnEnemy()
    {
        GameObject spawnedEnemy = Instantiate(enemy, spawnArea[Random.Range(0, spawnArea.Length)].position,Quaternion.identity);
        spawnedEnemy.SetActive(true);
    }
}
