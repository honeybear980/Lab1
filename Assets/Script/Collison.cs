using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collison : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = Color.cyan;
        collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
}
