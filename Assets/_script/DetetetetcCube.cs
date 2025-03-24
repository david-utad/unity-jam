using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetetetetcCube : MonoBehaviour
{

    private bool IsInside;

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<monkeyMovement>() != null)
        {
            IsInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<monkeyMovement>() != null)
        {
            IsInside = false;
        }
    }
    private void Update()
    {
        if(IsInside == true)
        {
            Debug.Log("Kimichi");
        }
    }
}
