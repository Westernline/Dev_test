using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBull : MonoBehaviour
{


    public void OnTriggerEnter (Collider other) 
    {
        if (other.tag == "Portal")
        {
            Destroy(gameObject);            
        }
        if (other.tag == "Ulta")
        {
            Destroy(gameObject);            
        }
    } 

}
