using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class CounterTextUI : MonoBehaviour
{
    public void printCounterUI ()
    {
        GetComponent<Text>().text = "x" + GameplayController.instance.counterPlayerDropBoxUI;
    }
}
