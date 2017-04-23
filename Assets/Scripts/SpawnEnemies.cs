using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {

	void Start () {
        InvokeRepeating("spawnEnemies", 3, 3);
    }

    void spawnEnemies()
    {
        GameObject enemy = EnemiesPool.sharedInstance.getBullet();
        if (enemy)
        {
            Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Screen.height, Camera.main.farClipPlane / 2));
            enemy.transform.position = gameObject.transform.position;
            enemy.transform.rotation = Quaternion.identity;
            enemy.SetActive(true);
        }
    }
}
