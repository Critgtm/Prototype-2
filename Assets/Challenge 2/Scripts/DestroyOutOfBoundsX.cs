using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
     private float leftLimit = -30.0f;
    private float bottomLimit = -5.0f;

    void Update()
    {
        // Destroy dogs if they move too far left off-screen
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
        // Destroy balls if they fall below the bottom limit (triggers Game Over logic in your DetectGoal script)
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }
    }
}
