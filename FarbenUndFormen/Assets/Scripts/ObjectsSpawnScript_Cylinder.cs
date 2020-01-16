using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSpawnScript_Cylinder : MonoBehaviour
{
    public float timer = 0;
    public GameObject prefabCylinder;
    void Update()
    {
        timer++;
    }
    void OnTriggerEnter(Collider other)
    {
        if (timer > 300)
        {
            Debug.Log("Spawning new Cylinder!");
            GameObject CylinderPlayable = Instantiate(prefabCylinder, new Vector3(0.7f, 3.5f, 0f), Quaternion.identity);
            CylinderPlayable.name = "Cylinder_playable";
            timer = 0;
        }
    }
}