using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireChange : MonoBehaviour
{
    GameObject FireObject;
    float timer; 
    GameObject FirePrefab;
    bool timerTriggered;
    // Start is called before the first frame update
    void Start()
    {
        timer = 5;
        timerTriggered = false;
        FireObject = GameObject.Find("Fire");
        FirePrefab = GameObject.Find("Fire Green");
        FirePrefab.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (timerTriggered) {
            timer -= Time.deltaTime;
            Debug.Log(timer);
            if (timer < 0) {

                    FirePrefab.SetActive(true);
                    FireObject.SetActive(false);
                    timer = 1000000000;
                }
        }
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "NaCl")
        {
            timerTriggered = true; 
            Debug.Log("Do something else here");
        }
    }
}
