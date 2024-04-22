using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float growthRate = 0.1f;
    
    private void Update()
    {
        Vector3 scaleChange = Vector3.one * growthRate * Time.deltaTime;
        transform.localScale += scaleChange;
    }
}
