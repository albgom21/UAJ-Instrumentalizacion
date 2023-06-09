﻿using P3;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smolnikov : MonoBehaviour
{
    [SerializeField]
    GameObject Key = null;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Daga>())
        {
            Key.SetActive(true);
            Tracker.TrackEvent(new endLvlEvent(2));
            Destroy(gameObject);
        }
    }
}
