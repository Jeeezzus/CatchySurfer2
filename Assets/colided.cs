using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colided : MonoBehaviour
{
    public GameObject ouch;
    public AudioClip audio;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        ouch.SetActive(true);
        ouch.GetComponent<AudioSource>().Play();
    }
    private void OnTriggerExit(Collider other)
    {
        ouch.SetActive(false);
    }
}
