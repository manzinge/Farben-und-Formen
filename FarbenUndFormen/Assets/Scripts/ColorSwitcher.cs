using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitcher : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Contains("color"))
        {
            var targetColorObject= GameObject.Find(collision.gameObject.name);
            var targetMaterial = collision.gameObject.GetComponent<Renderer>().sharedMaterial;
            GetComponent<Renderer>().material = targetMaterial;
        }
    }
}
