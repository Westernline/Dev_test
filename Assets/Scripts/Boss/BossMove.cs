using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    public GameObject player;
    public float speed = 1.0f;
    public float rotSpeed = 100.0f;
    
    void Start()
    {

        player = GameObject.Find ("Player(Clone)") ;
    }

    void Update()
    {
        Vector3.Distance(this.transform.position, player.transform.position);
        Quaternion lookatWP = Quaternion.LookRotation(player.transform.position - this.transform.position);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,lookatWP,rotSpeed*Time.deltaTime);
        this.transform.Translate(0,0,speed*Time.deltaTime);

    }

}
