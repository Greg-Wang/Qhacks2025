using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class ChangePos : MonoBehaviour
{

    public InputActionReference testAction;
    public GameObject Player;
    // Start is called before the first frame update
    public GameObject Spawner;
        
    
    // Start is called before the first frame update

    private void TestAction1(InputAction.CallbackContext obj)
    {
        Player = GameObject.Find("XR Origin (XR Rig)");
        Spawner = GameObject.Find("Spawner");
        Debug.Log(Player.transform.position);
        Debug.Log(Spawner.transform.position);
        Player.transform.position = Spawner.transform.position;
    }
    void Start()
    {
       
        testAction.action.performed += TestAction1;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
