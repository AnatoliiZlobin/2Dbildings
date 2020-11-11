using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class BoxTouch : MonoBehaviour
{
    public GameplayController someclass;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            someclass.CounterTouch();
        }

    }
}
