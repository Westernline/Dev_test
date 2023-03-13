using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public static Shoot instance;
    //public float fireSpeed = 1;
    public GameObject Cam;
    public float range = 15;
    public GameObject bull;
    //public ParticleSystem trace;
    public Transform spawnBuul;
    //public AudioClip shot;
    //public AudioSource audioShot;
    //public float force = 100;

    // Start is called before the first frame update
    void Start()
    {
        Cam = GameObject.Find ("MainCamera") ;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shootGun();
        }
    }
    public void shootGun()
    {
        //audioShot.PlayOneShot(shot);
        //trace.Play();
        Instantiate(bull , spawnBuul.position, spawnBuul.rotation);
        RaycastHit hit ;
        if (Physics.Raycast(Cam.transform.position, Cam.transform.forward, out hit, range ))
        {
            /*if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal*force);
            }*/
            Debug.Log("Shoot");
        }
    }
    
}
