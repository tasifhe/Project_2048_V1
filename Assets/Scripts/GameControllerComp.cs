using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerComp : MonoBehaviour
{
    [SerializeField] GameObject fillPrefab;
    [SerializeField] Transform[] allCells;

    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnFill();
        }
    }
    public void SpawnFill()
    {
        int whichSpawn = Random.Range(0, allCells.Length);

        if(allCells[whichSpawn].childCount != 0)
        {
            Debug.Log(allCells[whichSpawn].name + "Already filled");
            SpawnFill();
            return;
        }

        float _chance = Random.Range(0f, 1f);
        Debug.Log(_chance);
        if(_chance < .2f)
        {
            return;
        }
        else if(_chance < .8f)
        {
            
            GameObject tempFill = Instantiate(fillPrefab, allCells[whichSpawn]);
            Debug.Log(2);
            Fill2048Comp tempFillComp = tempFill.GetComponent<Fill2048Comp>();
            tempFillComp.FillValueUpdate(2);
        }
        else
        {
            GameObject tempFill = Instantiate(fillPrefab, allCells[whichSpawn]);
            Debug.Log(4);
            Fill2048Comp tempFillComp = tempFill.GetComponent<Fill2048Comp>();
            tempFillComp.FillValueUpdate(4);
        }
    }
}
