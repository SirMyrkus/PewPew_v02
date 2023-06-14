using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;
    [SerializeField]
    private GameObject enemy2;
    [SerializeField]
    private float enemyInterval = 3.5f;
    [SerializeField]
    private float enemy2Interval = 8f;
    [SerializeField]
    private GameObject[] spawningEnemy;
    
    void Start()
    {
        StartCoroutine(spawnEnemy(enemyInterval, enemy));
        //StartCoroutine(spawnEnemy(enemy2Interval, enemy2));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        if (interval >= 1)
        {
            interval -= 0.1f;

        }
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, spawningEnemy[Random.Range(0, 4)].transform.position, Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
    

}
