using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swipe : MonoBehaviour
{
    private Vector2 startP;
    private Vector2 endP;
    public int lane = 1;

    public GameObject me;
    void Start()
    {
        me = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startP = Input.GetTouch(0).position;
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endP = Input.GetTouch(0).position;
            if(startP.x > endP.x)
            {
                Prev();
            }
            if (startP.x < endP.x)
            {
                Next();
            }
        }
    }

    void Prev()
    {
        if(lane > 0)
        {
            transform.position -= new Vector3 (2f,0,0);
            lane -= 1;
        }
    }

    void Next() {
        if (lane < 2)
        {
            transform.position += new Vector3(2f, 0, 0);
            lane += 1;
        }
    }
}
