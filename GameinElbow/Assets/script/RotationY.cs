using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationY : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 90f;
    void Update()
    {
        float rotationAmount = rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, rotationAmount);
    }
}
