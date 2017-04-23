using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    bool canShoot = true;

	void Update () {
        GameObject bullet = BulletsPool.sharedInstance.getBullet();
        if (bullet)
        {
            bullet.transform.position = gameObject.transform.position + new Vector3(1.2f, 1.2f, 0); ;
            bullet.transform.rotation = Quaternion.identity;
            bullet.SetActive(true);
        }
    }
}
