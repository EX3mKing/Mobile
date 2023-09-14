using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public float minTime;
    public float maxTime;
    public GameObject obj;
    public Vector3 spawn;
    public TMP_Text tmp;
    public static int Score;
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(Random.Range(minTime, maxTime));
        Instantiate(obj, spawn, Quaternion.identity);
        StartCoroutine(Start());
    }

    private void Update()
    {
        tmp.text = Score.ToString();
    }
    
}
