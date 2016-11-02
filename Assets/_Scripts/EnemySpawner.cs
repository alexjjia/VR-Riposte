using UnityEngine;
using System.Collections;


public class EnemySpawner : MonoBehaviour {

    public GameObject enemy;
    float boundX, boundZ;
    // Use this for initialization
	void Start () {
        InvokeRepeating("SpawnEnemy", 5, 5);
	}
	
	// Update is called once per frame
	void Update () {
        boundX = Random.Range(-40, 40);
        boundZ = Random.Range(-40, 40);
	}

    void SpawnEnemy()
    {
        Instantiate(enemy);
        enemy.transform.position = (new Vector3(boundX, 0, boundZ));
    }
}
