using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public float launchForce = 1.0f;
    public float targetTimeHeld = 0.8f;

    private float secondsHeld = 0;
    private Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            secondsHeld += Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            float timePct = secondsHeld / targetTimeHeld;
            if (timePct > 1) { 
                timePct = 1;
            }

            if (rb != null)
            {
                rb.AddForce(transform.up * launchForce * timePct);
                secondsHeld = 0;
            } 

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("PlayerBall"))
        {
            rb = collision.rigidbody;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        rb = null;
    }
}
