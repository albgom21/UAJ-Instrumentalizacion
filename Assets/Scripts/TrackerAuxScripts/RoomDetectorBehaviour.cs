using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomDetectorBehaviour : MonoBehaviour
{
    [SerializeField] private int roomId;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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
