using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Main Camera");
        Player.transform.position = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
