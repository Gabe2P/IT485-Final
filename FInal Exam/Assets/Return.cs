using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        other.transform.position = Vector3.zero;
    }
}
