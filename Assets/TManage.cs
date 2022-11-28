using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TManage : MonoBehaviour
{
    private List<TerrainItem> _terrains;
    void Start()
    {
        _terrains = new List<TerrainItem>();
        for (var i = 0; i < transform.childCount; i++)
        {
            _terrains.Add(transform.GetChild(i).GetComponent<TerrainItem>());
            _terrains[i].gameObject.SetActive(false);
            Debug.Log($"{_terrains[0].name}");
        }

        DisplayRandomTerrain();
    }

    private void DisplayRandomTerrain()
    {
        var randomNumber = Random.Range(0, transform.childCount - 1);
        _terrains[randomNumber].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
