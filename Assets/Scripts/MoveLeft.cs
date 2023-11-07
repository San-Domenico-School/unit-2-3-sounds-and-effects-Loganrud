using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 20;
    private float leftBound = -15;
    private PlayerController playerControllerScript;
    public bool gameOver { get; private set; }

    // Update is called once per frame
    private void Update()
    {
        if (gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
    
}
