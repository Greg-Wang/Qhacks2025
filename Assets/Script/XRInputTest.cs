using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;


public class XRInputTest : MonoBehaviour
{
    public Camera vrCamera; // Reference to the VR Camera
    public float interactionDistance = 5f; // Distance to detect objects
    public LayerMask interactableLayer; // Layer for interactable objects
    public GameObject textWindowPrefab; // Prefab for the text window
    private GameObject activeTextWindow;
    public InputActionReference testAction;
    string textSave;
    // Start is called before the first frame update

    private void TestActionThing(InputAction.CallbackContext obj)
    {
        CheckInteraction();

    }
    void CheckInteraction()
    {
        Ray ray = new Ray(vrCamera.transform.position, vrCamera.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactionDistance, interactableLayer))
        {

            GameObject hitObject = hit.collider.gameObject;
            if (hitObject.tag == "NaCl" || hitObject.tag == "Int")
            {
                DisplayTextWindow(hitObject);
            }
        }
    }

    void DisplayTextWindow(GameObject targetObject)
    {
        if (activeTextWindow != null)
        {
            Destroy(activeTextWindow); // Remove any existing text window
        }
        textSave = targetObject.GetComponent<TextThing>().text;
        Debug.Log(targetObject);
        Vector3 windowPosition = targetObject.transform.position + Vector3.up * 1.2f; // Position above the object
        Debug.Log(windowPosition);
        windowPosition[1] -= 0.5f;
        activeTextWindow = Instantiate(textWindowPrefab, windowPosition, Quaternion.identity);
        Debug.Log(activeTextWindow.GetComponentInChildren<TMP_Text>().text);
        activeTextWindow.GetComponentInChildren<TMP_Text>().text = textSave;
        Text windowText = activeTextWindow.GetComponentInChildren<Text>();
        if (windowText != null)
        {
            windowText.text = "Interacted with: " + targetObject.name;
        }

        activeTextWindow.transform.SetParent(targetObject.transform); // Attach to the target object
    }
    void Start()
    {
        testAction.action.performed += TestActionThing;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
