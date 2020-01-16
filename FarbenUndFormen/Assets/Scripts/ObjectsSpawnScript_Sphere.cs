using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSpawnScript_Sphere : MonoBehaviour
{
    public float timer = 0;
    public GameObject prefabSphere;
    void Update()
    {
        timer++;
    }
    void OnTriggerEnter(Collider other)
    {
        if (timer > 300)
        {
            Debug.Log("Spawning new Sphere!");
            GameObject SpherePlayable = Instantiate(prefabSphere, new Vector3(-0.3f, 3.5f, 0f), Quaternion.identity);
            SpherePlayable.name = "Sphere_playable";
            timer = 0;
        }
    }
}