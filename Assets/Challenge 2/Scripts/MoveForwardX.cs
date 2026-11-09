using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 moveDirection = Vector3.down; // Vector3.down for balls, Vector3.left for dogs

    void Update()
    {
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
    }
}
