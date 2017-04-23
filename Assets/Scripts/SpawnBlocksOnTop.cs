using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocksOnTop : MonoBehaviour {

    void Start()
    {
        InvokeRepeating("spawnDefences", 2, 2);
        InvokeRepeating("spawnAttack", 3, 1);
    }

    void spawnDefences()
    {
        GameObject block = ObjectsPool.sharedInstance.getBullet();
        if (block)
        {
            Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Screen.height, Camera.main.farClipPlane / 2));
            block.transform.position = screenPosition;
            block.transform.rotation = Quaternion.identity;
            block.SetActive(true);
        }
    }

    void spawnAttack()
    {
        GameObject block = FireBlocksPool.sharedInstance.getBullet();
        if (block)
        {
            Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Screen.height, Camera.main.farClipPlane / 2));
            block.transform.position = screenPosition;
            block.transform.rotation = Quaternion.identity;
            block.SetActive(true);
        }
    }
}
