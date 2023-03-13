using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullMove : MonoBehaviour
{
    public Transform playergame;
    Vector3 myVector ;
    float x;
    float y;
    float z;
    //public GameObject bull;
    public GameObject player;
    public GameObject DestroyBull;
    public float speed = 1.0f;
    public float rotSpeed = 100.0f;
    public static BullMove instance;



    void Start()
    {
        //bull = GameObject.Find ("bullBoss(Clone)") ;
        player = GameObject.Find ("Player(Clone)") ;
        //playergame = GameObject.Find ("Player") ;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3.Distance(this.transform.position, player.transform.position);
        Quaternion lookatWP = Quaternion.LookRotation(player.transform.position - this.transform.position);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,lookatWP,rotSpeed*Time.deltaTime);
        this.transform.Translate(0,0,speed*Time.deltaTime);
        
        
        /*if (Portal.OnTriggerExit(Collider))
        {
            StartBullDestroy ();
        }*/

        
    }
    public void StartBullDestroy ()
    {
        myVector = playergame.transform.position ;
        Instantiate(DestroyBull).transform.position = myVector;
        player = DestroyBull ;
        //Destroy(DestroyBull,100.0f);
    }
    

}
