using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class XRInputSwitchScenes : MonoBehaviour
{

    public InputActionReference testAction;
    float timer;
    bool triggerSceneSwitch;
    int sceneNum;

    // Start is called before the first frame update

    private void TestActionThing(InputAction.CallbackContext obj)
    {
        Debug.Log("Hello, World");
        if (triggerSceneSwitch == false){
            triggerSceneSwitch = true;
        }
        else{
            if (sceneNum != 2){
                sceneNum = SceneManager.GetActiveScene().buildIndex + 1;
                SceneManager.LoadScene(sceneNum);
            }else{
                sceneNum = 0;
                SceneManager.LoadScene(0);
            }
        }

    }
    void Start()
    {
        sceneNum = SceneManager.GetActiveScene().buildIndex;
        triggerSceneSwitch = false;
        testAction.action.performed += TestActionThing;
        timer = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (triggerSceneSwitch == true)
        {
            timer -= Time.deltaTime;
        }
        if (timer < 0) {
            timer = 3;
            triggerSceneSwitch = false;
                   
        }

    }
}
