using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class BallController : MonoBehaviour
{
    //public Animator fadePanel;
    public TextMeshProUGUI timeTxt;
    public float timeGiven;

    private float _timeRemaining;
    // Start is called before the first frame update
    void Start()
    {
        _timeRemaining = timeGiven;
        transform.position = new Vector3(Random.Range(-3, 3), 10, Random.Range(-3, 3));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -30)
        {
            //fadePanel.SetBool("Fade",true);
            StartCoroutine(GlobalFunctions.LoadSceneByIndex(0, 2f));
        }

        if (_timeRemaining > 0)
        {
            if (transform.position.y > -10)
            {
                _timeRemaining -= Time.deltaTime;
            }
            timeTxt.text = Mathf.Round(_timeRemaining).ToString();
        }
        else
        {
            //fadePanel.SetBool("Lost",true);
            StartCoroutine(GlobalFunctions.LoadSceneByIndex(0, 2f));
        }
    }
}