using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public int health = 50;
    public GameObject bull;
    public Transform spawnBuul;

    public void OnTriggerEnter (Collider other) 
    {
        if (other.tag == "Bull")
        {
            health -=50;
            if (health <= 0)
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
                Instantiate(bull , spawnBuul.position, spawnBuul.rotation);
                DestroyPlayer.Power +=15;
                if (DestroyPlayer.Power >= 100)
                {
                    DestroyPlayer.Power =100;
                }

                GameManager.instance.InrementScore();
            }        
        }
        if (other.tag == "heal")
        {
            health -=50;
            if (health <= 0)
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
                DestroyPlayer.health +=50;
                if (DestroyPlayer.health >= 100)
                {
                    DestroyPlayer.health =100;
                }

                GameManager.instance.InrementScore();
            }
            
            
        }
        if (other.tag == "Ulta")
        {
            Destroy(gameObject);
            GameManager.instance.InrementScore();            
        }
        
    } 
}
