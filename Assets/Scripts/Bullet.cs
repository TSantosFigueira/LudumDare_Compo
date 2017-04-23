using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	void Update () {
        if (gameObject.activeInHierarchy)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-10, 10), Random.Range(0,10));
            //GameObject.FindGameObjectWithTag("soundManager").GetComponent<Sounds>().playSound("shot", 0.1f);
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "limits")
        {
            gameObject.SetActive(false);
        }

        else if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            GameObject.FindGameObjectWithTag("soundManager").GetComponent<Sounds>().playSound("death", 0.5f);
            UI.gameOver = true;
        }

        else if(collision.gameObject.tag == "defenceBlock" || collision.gameObject.tag == "attackBlock")
        {
            collision.gameObject.transform.parent = GameObject.FindGameObjectWithTag("blockPool").transform;
            GameObject.FindGameObjectWithTag("soundManager").GetComponent<Sounds>().playSound("explosion", 0.5f);
            collision.gameObject.SetActive(false);      
        }

        else if (collision.gameObject.tag == "enemy")
        {
            collision.gameObject.SetActive(false);
        }
    }
}
