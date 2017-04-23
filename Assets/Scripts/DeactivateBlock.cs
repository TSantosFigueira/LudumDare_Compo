using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateBlock : MonoBehaviour {

    private void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.tag == "limits")
        {
            gameObject.SetActive(false);         
        }
         
    }

}
