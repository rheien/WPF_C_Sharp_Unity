using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotation : MonoBehaviour
{

    private float propellerRotationSpeed = 2000f;

    void Update()
    {
        transform.Rotate(Vector3.forward * propellerRotationSpeed * Time.deltaTime);
    }
}

