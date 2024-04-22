using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;

    private void Update()
    {
        Vector3 moveDirection = transform.forward;
        transform.position += moveDirection * _moveSpeed * Time.deltaTime;
    }
}
