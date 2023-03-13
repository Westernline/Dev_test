using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bull : MonoBehaviour
{
    //public Transform originalObject; 
    //public Transform reflectedObject; 
    public int speed = -25;

    void Update()
    {
        //reflectedObject.position = Vector3.Reflect (originalObject.position, Vector3.right );
        transform.Translate(Vector3.forward*speed * Time.deltaTime);
        Destroy(gameObject, 5.0f);
    }
    /*public void OnTriggerEnter (Collider other) 
    {
        if (other.tag == "Bot")
        {
            if (DestroyPlayer.health <= 100)
            {
                DestroyPlayer.health += 50;

                //GameManager.instance.InrementScore();
            }
            if (DestroyPlayer.health >= 0)
            {
                Destroy(other.gameObject);
                

                //GameManager.instance.InrementScore();
            }
            
            
        }
        
    } */
}
