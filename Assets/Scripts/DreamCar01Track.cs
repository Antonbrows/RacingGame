using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCar01Track : MonoBehaviour
{
    public GameObject TheMarker;
    public GameObject Mark01;
    public GameObject Mark02;
    public GameObject Mark03;
    public GameObject Mark04;
    public GameObject Mark05;
    public GameObject Mark06;
    public GameObject Mark07;
    public int MarkTracer;
    void Update()
    {
        if (MarkTracer == 0)
        {
            TheMarker.transform.position = Mark01.transform.position;
        }
        if (MarkTracer == 1)
        {
            TheMarker.transform.position = Mark02.transform.position;
        }
        if (MarkTracer == 2)
        {
            TheMarker.transform.position = Mark03.transform.position;
        }
        if (MarkTracer == 3)
        {
            TheMarker.transform.position = Mark04.transform.position;
        }
        if (MarkTracer == 4)
        {
            TheMarker.transform.position = Mark05.transform.position;
        }
        if (MarkTracer == 5)
        {
            TheMarker.transform.position = Mark06.transform.position;
        }
        if (MarkTracer == 6)
        {
            TheMarker.transform.position = Mark07.transform.position;
        }
        
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "DreamCar01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracer += 1;
            if(MarkTracer == 7)
            {
                MarkTracer = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
