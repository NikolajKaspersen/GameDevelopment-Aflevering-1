using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    [SerializeField] private Transform Player;

    [SerializeField] private Transform respawnPoint;

    void OnTriggerEnter(Collider other)
    {
        Player.transform.position = respawnPoint.transform.position;
        Player.transform.rotation = respawnPoint.transform.rotation;
    }
    // Start is called before the first frame update
    
}
