using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ObjectCheck : MonoBehaviour
{
    public GameObject Cube;
    public GameObject Sphere;
    public GameObject Cylinder;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        string compareObject = "";
        GameObject targetCover = new GameObject();

        var destroyObject = GameObject.Find(other.gameObject.name);
        var color = destroyObject.gameObject.GetComponent<Renderer>().sharedMaterial.ToString();
        var CoverHolder = GameObject.Find("Cover");

        for (int i = 0; i < CoverHolder.transform.childCount; i++)
        {
            if (CoverHolder.transform.GetChild(i).gameObject.activeSelf == true)
            {
                targetCover = CoverHolder.transform.GetChild(i).gameObject;
                //compareObject = CoverHolder.transform.GetChild(i).gameObject;
                break;
            }
        }

        string targetForm = targetCover.name.Split('-')[1];
        switch (targetForm)
        {
            case "cylinder": compareObject = "Cylinder"; break;
            case "square": compareObject = "Cube"; break;
            case "sphere": compareObject = "Sphere"; break;
            default: break;
        }

        if (compareObject == destroyObject.name.Replace("_playable","") && color == targetCover.gameObject.GetComponent<Renderer>().sharedMaterial.ToString())
        {
            Debug.Log("Correct object");
            CoverHolder = GameObject.Find("CoverHolder");
            CoverHolder.GetComponent<CoverSwitcher>().PickRandomCap();
        }
        else
        {
            Debug.Log("Wrong object");
        }

        Destroy(other.gameObject);


    }
}

