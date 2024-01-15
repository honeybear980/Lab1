using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceCylinder : MonoBehaviour
{
   private Rigidbody rb;

   private void OnCollisionEnter(Collision collision)
   {
      collision.gameObject.GetComponent<Rigidbody>().AddForce(0,1000,1000);
   }
}
