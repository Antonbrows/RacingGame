using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    //list all triggers

    //add all triggers to array

    void OnTriggerEnter()
    {
        //disable triggered & enable next in array
        LapCompleteTrig.SetActive(true);
        HalfLapTrig.SetActive(false);
    }
}
