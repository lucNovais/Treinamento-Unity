using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    public bool sensor = false;

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log(other.gameObject.name);
        if (other.gameObject.CompareTag("line"))
        {
            sensor = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.CompareTag("line"))
        {
            sensor = false;
        }
    }

}
