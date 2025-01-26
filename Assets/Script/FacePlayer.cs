using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    private GameObject player; // Reference to the player's transform
    private Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Main Camera");
        playerTransform = player.transform;
    }

    // Update is called once per frame

    void Update()
    {
        if (playerTransform != null)
        {
            Vector3 directionToPlayer = playerTransform.position - transform.position;
            directionToPlayer.y = 0; // Keep the object upright
            Quaternion targetRotation = Quaternion.LookRotation(directionToPlayer);
            targetRotation *= Quaternion.Euler(0, 90, 0);
            transform.rotation = targetRotation;
        }
    }
}
