using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
  private void OnTriggerEnter(Collider other)
    {
        // ONLY destroy if the ball actually hits the dog
        if (other.CompareTag("Dog"))
        {
            Destroy(gameObject);
        }
    }
}
