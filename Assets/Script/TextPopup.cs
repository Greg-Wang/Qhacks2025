using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class VRObjectInteraction : MonoBehaviour
{
    public Camera vrCamera; // Reference to the VR Camera
    public float interactionDistance = 5f; // Distance to detect objects
    public LayerMask interactableLayer; // Layer for interactable objects
    public GameObject textWindowPrefab; // Prefab for the text window

    private GameObject activeTextWindow;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Check for controller button press
        {
            CheckInteraction();
        }
    }

    void CheckInteraction()
    {
        Ray ray = new Ray(vrCamera.transform.position, vrCamera.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactionDistance, interactableLayer))
        {
            GameObject hitObject = hit.collider.gameObject;
            DisplayTextWindow(hitObject);
        }
    }

    void DisplayTextWindow(GameObject targetObject)
    {
        if (activeTextWindow != null)
        {
            Destroy(activeTextWindow); // Remove any existing text window
        }

        Vector3 windowPosition = targetObject.transform.position + Vector3.up ; // Position above the object
        Debug.Log(windowPosition);
        activeTextWindow = Instantiate(textWindowPrefab, windowPosition, Quaternion.identity);

        Text windowText = activeTextWindow.GetComponentInChildren<Text>();
        if (windowText != null)
        {
            windowText.text = "Interacted with: " + targetObject.name;
        }

        activeTextWindow.transform.SetParent(targetObject.transform); // Attach to the target object
    }
}
