using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMaze : MonoBehaviour
{
    private int inverted = GlobalFunctions.Inverted; // 1 = normal, -1 = inverted
    public float rotateSpeed;
    public float maxRotation;
    public GameObject ball;
    
    private float _mouseX, _mouseY;
    private bool _mouseClick;

    private void Update()
    {
        _mouseClick = Input.GetMouseButton(0);
        if (Input.GetMouseButtonDown(0)) ball.transform.Rotate(Vector3.up, 0.01f);
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Tab)) GlobalFunctions.LoadSceneByIndex(0);
    }

    void FixedUpdate()
    {
        if (!_mouseClick) return;
        
        _mouseX += Input.GetAxis("Mouse X");
        _mouseY += Input.GetAxis("Mouse Y");

        float rotateX = _mouseX * rotateSpeed;
        float rotateZ = _mouseY * rotateSpeed;

        rotateX = Mathf.Clamp(rotateX * inverted, -maxRotation, maxRotation);
        rotateZ = Mathf.Clamp(rotateZ * inverted, -maxRotation, maxRotation);
        float rotY = transform.rotation.y;

        transform.eulerAngles = new Vector3(rotateZ, rotY, -rotateX);
    }
    
}