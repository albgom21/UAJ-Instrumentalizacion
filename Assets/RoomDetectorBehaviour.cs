using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomDetectorBehaviour : MonoBehaviour
{
    [SerializeField] int roomId;
    private bool playerInRoom;
    // Start is called before the first frame update
    void Start()
    {
        playerInRoom = false;
    }

    void onTriggerEnter2D(Collision2D collission)
    {

    }
}
