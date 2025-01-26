using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volcanoEffect : MonoBehaviour
{
    public GameObject Finished;
    GameObject Cylinder;
    // Start is called before the first frame update
    void Start()
    {
        Cylinder = GameObject.Find("Cylinder Baking");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Int")
        {
            Destroy(collision.gameObject);
            Finished.SetActive(true);
            Cylinder.SetActive(false);
        }
    }


}
