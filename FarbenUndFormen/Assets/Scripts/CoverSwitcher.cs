using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoverSwitcher : MonoBehaviour
{
    public GameObject[] cover;

    public void PickRandomCap()
    {
     var roll = Random.Range(0, 12);

     for (var i = 0; i < 12; i++)
     {
      var indexIsRoll = i == roll;
      cover[i].SetActive(indexIsRoll);
	 }
	}

    private void Start()
    {
     PickRandomCap();
	}
}


