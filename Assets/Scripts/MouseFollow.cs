using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{

    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;

    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);

        if (Input.GetKeyDown(KeyCode.R))
        {
            gameObject.transform.Rotate(0, 0, 90);
        }
    }
}
