using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class BoxDetectTouch : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Box")
        {

                GameplayController.instance.box_Spawner.SpawnBox();
                print("Box");

            
        }
    }
}
