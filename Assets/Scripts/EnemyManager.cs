using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //create a link to the monster prefabs
    public GameObject enemyWeedPrefab;
    public GameObject enemyCrabPrefab;
    //create a list to manage the monsters
    public List<Monster> allEnemies = new List<Monster>();

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 6; i++)
        {
            float x = Random.Range(-10f, 10f);
            float y = 1;
            float z = Random.Range(-10f, 10f);
            Vector3 spawnPosition = new Vector3(x, y, z);
            GameObject clone = Instantiate(enemyWeedPrefab, spawnPosition, Quaternion.identity);
            allEnemies.Add(clone.GetComponent<Monster>());
        }
        Instantiate(enemyCrabPrefab);
        allEnemies.Add(enemyCrabPrefab.GetComponent<Monster>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
