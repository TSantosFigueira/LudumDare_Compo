using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachObject : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "defenceBlock" || collision.gameObject.tag == "attackBlock")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            //collision.gameObject.transform.localPosition = gameObject.transform.position;

            if (gameObject.transform.parent.gameObject.tag == "Player")
            {
                collision.gameObject.transform.parent = gameObject.transform.parent;
            }

        }

        if(collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            gameObject.transform.parent = collision.gameObject.transform;
        }
    }    
}
