using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompareForm : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
{
  if (IsCorrectItem(other))
  {
    Debug.Log("Richtige Form!");
  }
  else
  {
    Debug.Log("Leider die falsche Form!");
  }
}
 public GameObject expectedItem;

    private bool IsCorrectItem(Collider item)
{
  // Gib "true" zurück, wenn das Item, das durchfliegt, dem erwarteten Item entspricht.
  return item.gameObject == expectedItem;
}

}
