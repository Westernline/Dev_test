using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class Portal : MonoBehaviour
{

    
    //public List <GameObject> bull;
    public GameObject DestroyGameObject;
    public GameObject player;
    float x;
    float y;
    float z;
    public static Portal instance;

    void Update ()
    {

    }

   /* public void OnTriggerEnter(Collider other) 
    {
        if (other.transform.tag == "BullBoss")
        {
            Destroy(other.gameObject);
        }
    }*/

    public void OnTriggerExit(Collider other) 
    {
        if (other.transform.tag == "Player")
        {
            x = Random.Range(-16, 16);
            y = 0;
            z = Random.Range(-16, 16);
            player.transform.position = new Vector3 (x,y,z) ;
            Debug.Log("Exit");
            
            DestroyGameObject.SetActive(true);
            StartExampleCoroutine();
            
            //BullMove.instance.StartBullDestroy();
            /*if (gameObject.CompareTag("BullBoss"))
            {
                Destroy(gameObject); 
            }
            Destroy(GameObject.Find ("bullBoss(Clone)"));*/
            
        }
        
    }
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1f);
        DestroyGameObject.SetActive(false);
    }
    public void StartExampleCoroutine()
    {
        StartCoroutine(ExampleCoroutine());
    }
    /*public void StartBullDestroy ()
    {
        bull.Add(GameObject.Find ("bullBoss(Clone)"));
    }*/
}