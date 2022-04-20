using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone : MonoBehaviour
{
    public static EventHandler<bool> ZoneHitHandler;
    [SerializeField]
    private bool isWinZone;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ZoneHitHandler?.Invoke(this, isWinZone);
        }
    }
}
