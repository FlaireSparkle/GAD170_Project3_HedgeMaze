using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    #region Area Boss
    //create a link to the monster prefabs
    public GameObject areaBossPrefab;
    public Vector3 bossSpawnLocation;
    #endregion
    #region Area Mob
    public GameObject areaMobPrefab;
    public int mobCount = 6;
    public Vector3 spawnZoneMax;
    public Vector3 spawnZoneMin;
    //create a list to manage the monsters
    public List<Monster> allEnemies = new List<Monster>();
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < mobCount; i++)
        {
            float x = Random.Range(spawnZoneMin.x,spawnZoneMax.x);
            float y = Random.Range(spawnZoneMin.y, spawnZoneMax.y);
            float z = Random.Range(spawnZoneMin.z,spawnZoneMax.z);
            Vector3 spawnPosition = new Vector3(x, y, z);
            GameObject clone = Instantiate(areaMobPrefab, spawnPosition, Quaternion.identity);
            allEnemies.Add(clone.GetComponent<Monster>());
        }
        Instantiate(areaBossPrefab, bossSpawnLocation, Quaternion.identity);
        allEnemies.Add(areaBossPrefab.GetComponent<Monster>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
