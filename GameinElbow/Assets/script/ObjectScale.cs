using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScale : MonoBehaviour
{
    [SerializeField] private float _growthRate = 0.1f;

    private void Update()
    {
        Vector3 scaleChange = Vector3.one * _growthRate * Time.deltaTime;
        transform.localScale += scaleChange;
    }
}
//hqiufiuhegw
