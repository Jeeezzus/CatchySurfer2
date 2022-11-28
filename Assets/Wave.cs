using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public float frame = 0;
    public GameObject[] changeables;

    void Start()
    {
        
    }


    void Update()
    {
        frame += 0.001f;
        float deform = Mathf.Sin(frame);
        float deform2 = Mathf.Sin(frame*2f);
        changeables = GameObject.FindGameObjectsWithTag("changable");
        Debug.Log(deform);
        for (int i = 0; i<changeables.Length; i++)
        {
            changeables[i].GetComponent<Renderer>().material.SetFloat("_CurveX", deform/4f);
            changeables[i].GetComponent<Renderer>().material.SetFloat("_CurveY", deform2*8);
        }

    }
}
