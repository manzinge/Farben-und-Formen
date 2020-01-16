using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompareColor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
{
  if (IsCorrectColor(other))
  {
    Debug.Log("Richtige Farbe!");
  }
  else
  {
    Debug.Log("Leider die falsche Farbe!");
  }
}
 public Material expectedColor;

    private bool IsCorrectColor(Collider material)
{
  // Gib "true" zurück, wenn das Item, das durchfliegt, die erwartete Farbe hat.
  return material == expectedColor;
}

}
