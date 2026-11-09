using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject Dog;
    private float fireRate = 1.0f;
    private float nextFire = 0.0f;

    void Update()
    {
        // On spacebar press, send dog if enough time has elapsed
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(Dog, transform.position, Dog.transform.rotation);
        }
    }
}
