using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    spawnmager roadspawner;
    // Start is called before the first frame update
    void Start()
    {
        roadspawner = GetComponent<spawnmager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawntriggerevent()
    {
        roadspawner.MoveRoad();
    }
}
