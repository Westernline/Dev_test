using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotMove : MonoBehaviour
{
    public GameObject player;
    public float speed = 2.5f;
    public float rotSpeed = 100.0f;
    public int time = 0;
    

    void Start()
    {
        player = GameObject.Find ("Player(Clone)") ;
        Up ();
    }

    // Update is called once per frame
    void Update()
    {
        Play();
    }
    public void Up ()
    {
        StartExampleCoroutine();
    }
    public void Play()
    {

        if(time == 10 )
        {
            Vector3.Distance(this.transform.position, player.transform.position);
            Quaternion lookatWP = Quaternion.LookRotation(player.transform.position - this.transform.position);
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,lookatWP,rotSpeed*Time.deltaTime);
            this.transform.Translate(0,0,speed*Time.deltaTime);
        }
        if (time <= 8)
        {
            transform.position += Vector3.up *0.5f* Time.deltaTime ;
        }
    }

    

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
        
        if (time <= 8)
        {
            Up ();
            time +=1;
            if (time == 9)
            {
                yield return new WaitForSeconds(2.0f);
                time +=1;
            }
        }
        
        

  
    }
    public void StartExampleCoroutine()
    {
        StartCoroutine(ExampleCoroutine());
    }


}
