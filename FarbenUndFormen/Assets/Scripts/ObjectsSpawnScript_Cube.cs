using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSpawnScript_Cube : MonoBehaviour
{
    public float timer = 0;
    public GameObject prefabCube;
    
    void Update()
    {
        timer++;
    }

    void OnTriggerEnter(Collider other)
    {
        if(timer > 300)
        {
            Debug.Log("Spawning new Cube!");
            GameObject CubePlayable = Instantiate(prefabCube, new Vector3(-1.3f, 3.5f, 0f),Quaternion.identity);
            CubePlayable.name = "Cube_playable";
            timer = 0;
        }
    }
}