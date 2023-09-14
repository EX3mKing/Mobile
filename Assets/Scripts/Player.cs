using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public float jump;
    private bool _canJump;
    private bool _requestJump;
    public float bufferTime;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0)
        {
            StartCoroutine(JumpBuffer());
        }

        if (_requestJump && _canJump)
        {
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            _canJump = false;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _canJump = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("lose");
            GlobalFunctions.LoadSceneByIndex(0);
        }
    }

    IEnumerator JumpBuffer()
    {
        _requestJump = true;
        yield return new WaitForSeconds(bufferTime);
        _requestJump = false;

    }
}
