using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spacebarCooldown = 2.0f;
    private float nextAllowedTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextAllowedTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            nextAllowedTime = Time.time + spacebarCooldown;
        }
    }
}
