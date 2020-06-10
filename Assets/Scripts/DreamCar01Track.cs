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
    public GameObject Mark08;
    public GameObject Mark09;
    public GameObject Mark10;
    public GameObject Mark11;
    public GameObject Mark12;
    public GameObject Mark13;
    public GameObject Mark14;
    public GameObject Mark15;
    public GameObject Mark16;
    public GameObject Mark17;
    public GameObject Mark18;
    public GameObject Mark19;
    public GameObject Mark20;
    public GameObject Mark21;
    public GameObject Mark22;
    public GameObject Mark23;
    public GameObject Mark24;
    public GameObject Mark25;
    public GameObject Mark26;
    public GameObject Mark27;
    public GameObject Mark28;
    public GameObject Mark29;
    public GameObject Mark30;
    public GameObject Mark31;
    public GameObject Mark32;
    public GameObject Mark33;
    public GameObject Mark34;
    public GameObject Mark35;
    public GameObject Mark36;
    public GameObject Mark37;
    public GameObject Mark38;
    public GameObject Mark39;
    public GameObject Mark40;
    public GameObject Mark41;
    public GameObject Mark42;
    public GameObject Mark43;
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
        if (MarkTracer == 7)
        {
            TheMarker.transform.position = Mark08.transform.position;
        }
        if (MarkTracer == 8)
        {
            TheMarker.transform.position = Mark09.transform.position;
        }
        if (MarkTracer == 9)
        {
            TheMarker.transform.position = Mark10.transform.position;
        }
        if (MarkTracer == 10)
        {
            TheMarker.transform.position = Mark11.transform.position;
        }
        if (MarkTracer == 11)
        {
            TheMarker.transform.position = Mark12.transform.position;
        }
        if (MarkTracer == 12)
        {
            TheMarker.transform.position = Mark13.transform.position;
        }
        if (MarkTracer == 13)
        {
            TheMarker.transform.position = Mark14.transform.position;
        }
        if (MarkTracer == 14)
        {
            TheMarker.transform.position = Mark15.transform.position;
        }
        if (MarkTracer == 15)
        {
            TheMarker.transform.position = Mark16.transform.position;
        }
        if (MarkTracer == 16)
        {
            TheMarker.transform.position = Mark17.transform.position;
        }
        if (MarkTracer == 17)
        {
            TheMarker.transform.position = Mark18.transform.position;
        }
        if (MarkTracer == 18)
        {
            TheMarker.transform.position = Mark19.transform.position;
        }
        if (MarkTracer == 19)
        {
            TheMarker.transform.position = Mark20.transform.position;
        }
        if (MarkTracer == 20)
        {
            TheMarker.transform.position = Mark21.transform.position;
        }
        if (MarkTracer == 21)
        {
            TheMarker.transform.position = Mark22.transform.position;
        }
        if (MarkTracer == 22)
        {
            TheMarker.transform.position = Mark23.transform.position;
        }
        if (MarkTracer == 23)
        {
            TheMarker.transform.position = Mark24.transform.position;
        }
        if (MarkTracer == 24)
        {
            TheMarker.transform.position = Mark25.transform.position;
        }
        if (MarkTracer == 25)
        {
            TheMarker.transform.position = Mark26.transform.position;
        }
        if (MarkTracer == 26)
        {
            TheMarker.transform.position = Mark27.transform.position;
        }
        if (MarkTracer == 27)
        {
            TheMarker.transform.position = Mark28.transform.position;
        }
        if (MarkTracer == 28)
        {
            TheMarker.transform.position = Mark29.transform.position;
        }
        if (MarkTracer == 29)
        {
            TheMarker.transform.position = Mark30.transform.position;
        }
        if (MarkTracer == 30)
        {
            TheMarker.transform.position = Mark31.transform.position;
        }
        if (MarkTracer == 31)
        {
            TheMarker.transform.position = Mark32.transform.position;
        }
        if (MarkTracer == 32)
        {
            TheMarker.transform.position = Mark33.transform.position;
        }
        if (MarkTracer == 33)
        {
            TheMarker.transform.position = Mark34.transform.position;
        }
        if (MarkTracer == 34)
        {
            TheMarker.transform.position = Mark35.transform.position;
        }
        if (MarkTracer == 35)
        {
            TheMarker.transform.position = Mark36.transform.position;
        }
        if (MarkTracer == 36)
        {
            TheMarker.transform.position = Mark37.transform.position;
        }
        if (MarkTracer == 37)
        {
            TheMarker.transform.position = Mark38.transform.position;
        }
        if (MarkTracer == 38)
        {
            TheMarker.transform.position = Mark39.transform.position;
        }
        if (MarkTracer == 39)
        {
            TheMarker.transform.position = Mark40.transform.position;
        }
        if (MarkTracer == 40)
        {
            TheMarker.transform.position = Mark41.transform.position;
        }
        if (MarkTracer == 41)
        {
            TheMarker.transform.position = Mark42.transform.position;
        }
        if (MarkTracer == 42)
        {
            TheMarker.transform.position = Mark43.transform.position;
        }
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "DreamCar01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracer += 1;
            if(MarkTracer == 43)
            {
                MarkTracer = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
