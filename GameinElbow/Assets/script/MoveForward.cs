using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private void Update()
    {
        Vector3 moveDirection = transform.forward;
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
