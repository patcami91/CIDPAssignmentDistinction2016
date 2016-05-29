using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour{

    public Transform spawnPoint;
    public Transform spawnObject;
    public int spawnTotal;
    public float timeBetweenSpawns;
    

    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnGameObject());
	}

    // Update is called once per frame
    void Update()
    {
    }
    IEnumerator SpawnGameObject()
    {
        for (var x = 0; x < spawnTotal; x++)
        {
            Instantiate(spawnObject, spawnPoint.position, spawnPoint.rotation);
            yield return new WaitForSeconds(timeBetweenSpawns);
        }
    }
}
