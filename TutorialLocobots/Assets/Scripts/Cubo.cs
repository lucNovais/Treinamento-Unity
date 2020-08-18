using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public Vector3 aux;
    Rigidbody cuboRigibody;

    void Start()
    {
        cuboRigibody = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        Movimenta();
    }

    void Movimenta()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            aux = cuboRigibody.velocity;
            aux.x = -10;
            cuboRigibody.velocity = aux;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            aux = cuboRigibody.velocity;
            aux.x = 10;
            cuboRigibody.velocity = aux;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            aux = cuboRigibody.velocity;
            aux.z = 10;
            cuboRigibody.velocity = aux;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            aux = cuboRigibody.velocity;
            aux.z = -10;
            cuboRigibody.velocity = aux;
        }
    }
}
