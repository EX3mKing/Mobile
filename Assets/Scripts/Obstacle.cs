using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;
    public float timeToDestroy;
    private bool _scored = false;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(timeToDestroy);
        Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        transform.Translate(transform.forward * (speed * Time.fixedDeltaTime));
        if (transform.position.z > 0 && !_scored)
        {
            GameManager.Score++;
            _scored = true;
        }
    }
}
