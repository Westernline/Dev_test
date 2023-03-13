using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBoss : MonoBehaviour
{
    public int health = 100;
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
                DestroyPlayer.Power +=50;
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
