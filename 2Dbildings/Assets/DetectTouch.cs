using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

public class DetectTouch : MonoBehaviour
{
    public bool ifEndGame = false;
    private void OnCollisionEnter2D(Collision2D platformCollision)
    {
        if (ifEndGame == false)
        {
            ifEndGame = true;
            GameplayController.instance.box_Spawner.SpawnBox();
        }
        else if (ifEndGame == true)
        {
            print("End"); 
        }
    }
}
