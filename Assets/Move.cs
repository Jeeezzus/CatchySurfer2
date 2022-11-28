using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public double velocity;
    public GameObject me;
    // Start is called before the first frame update
    void Start()
    {
        me = this.gameObject;
        me.GetComponent<Rigidbody>().velocity -= new Vector3(0f, 0f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        velocity = me.GetComponent<Rigidbody>().velocity.z;
        if (me.GetComponent<Rigidbody>().velocity.z >= -60f) { 
             me.GetComponent<Rigidbody>().velocity -= new Vector3(0f,0f,0.002f);
        }
        else
        {
            me.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, -60f);
        }
    }
}
