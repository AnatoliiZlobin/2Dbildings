﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject box_Prfab;

    public void SpawnBox()
    {
        GameObject box_Obj = Instantiate(box_Prfab);
        box_Obj.transform.position = transform.position;
    }
}
