using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainItem : MonoBehaviour
{
    public GameObject me;
    public bool placed = false;
    public List<GameObject> _terrains;

    void Start()
    {
        me = this.gameObject;
}

    // Update is called once per frame
    void Update()
    {
     if(me.GetComponent<Transform>().position.z <= 150 && placed == false)
        {
            try
            {
                placed = true;
                var randomNumber = Random.Range(0, _terrains.Count);
                GameObject clone;
                clone = Instantiate(_terrains[randomNumber], new Vector3(0, 0, 190), Quaternion.identity);
                clone.GetComponent<Rigidbody>().velocity = me.GetComponent<Rigidbody>().velocity;
                clone.GetComponent<TerrainItem>().placed = false;
            }
            catch
            {
                placed = true;
                GameObject clone;
                clone = Instantiate(me, new Vector3(0, 0, 190), Quaternion.identity);
                clone.GetComponent<Rigidbody>().velocity = me.GetComponent<Rigidbody>().velocity;
                //clone.GetComponent<TerrainItem>().placed = false;
            }
        }
        if (me.GetComponent<Transform>().position.z <= -50)
        {
            Destroy(me);
        }
    }

}
