using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    public float speed = 1f;
    public GameObject player;

	void Start () {
        
	}
	
	void Update () {
        if (gameObject.activeInHierarchy)
        {
            float z = Mathf.Atan2((player.transform.position.y - transform.position.y), (player.transform.position.x - transform.position.x)) * Mathf.Rad2Deg - 90;
            transform.eulerAngles = new Vector3(0, 0, z);
            transform.GetComponent<Rigidbody2D>().AddForce(transform.up * speed);
        }
    }

    private void FixedUpdate()
    {
       
    }
}
