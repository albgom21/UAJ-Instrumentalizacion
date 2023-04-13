using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomDetectorBehaviour : MonoBehaviour
{
    enum RoomIds
    {
        ROOM_0,
        ROOM_1,
        ROOM_2,
        ROOM_3,
        ROOM_4,
        ROOM_5,
        ROOM_6,
        ROOM_7,
        ROOM_8,
        ROOM_9,
        ROOM_10,
        ROOM_11,
        ROOM_12,
        ROOM_13,
        ROOM_14,
        ROOM_15,
        ROOM_16,
        ROOM_17,
        ROOM_18,
        ROOM_19,
        ROOM_20,
        ROOM_21,
        ROOM_22,
        ROOM_23,
        ROOM_24,
        ROOM_25,
        ROOM_26,
        ROOM_27,
        ROOM_28,
        ROOM_29,
        HALL_0_1_3,
        HALL_1_2,
        HALL_2_3,
        HALL_3_4_18,
        HALL_4_5,
        HALL_5_6,
        HALL_6_7,
        HALL_7_8,
        HALL_8_9,
        HALL_9_10,
        HALL_7_11,
        HALL_11_12,
        HALL_5_13,
        HALL_13_14,
        HALL_14_15,
        HALL_14_16,
        HALL_16_17,
        HALL_18_19,
        HALL_14_22,
        HALL_19_20_21,
        HALL_21_22_23_24,
        HALL_24_25,
        HALL_24_26,
        HALL_26_27,
        HALL_26_28,
        HALL_26_29,
    }

    [SerializeField] private RoomIds roomId;

    private bool playerInRoom;
    // Start is called before the first frame update
    void Start()
    {
        playerInRoom = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        PlayerController pc = collision.GetComponent<PlayerController>();
        if (pc != null)
        {
            Debug.Log("POPOPOM");
        }
    }
}
