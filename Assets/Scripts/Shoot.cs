using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    bool canShoot = true;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canShoot)
        {
            GameObject bullet = BulletsPool.sharedInstance.getBullet();
            StartCoroutine("Wait1Sec");

            if (bullet && gameObject.transform.parent.gameObject.tag == "Player")
            {             
                bullet.transform.position = gameObject.transform.position + new Vector3(0.7f, 0.7f, 0);
                bullet.transform.rotation = Quaternion.identity;
                bullet.SetActive(true);
            }
        }
    }

    IEnumerator Wait1Sec()
    {
        canShoot = false;
        yield return new WaitForSeconds(1);
        canShoot = true;
    }
}
