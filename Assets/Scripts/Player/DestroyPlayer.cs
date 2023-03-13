using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyPlayer : MonoBehaviour
{
    public static int health = 100;
    public static int Power = 50;
    public int Pow;
    public int Hea;

    public TextMeshProUGUI HeaText;
    public TextMeshProUGUI PowText;
    public GameObject ShootGameOver;
    

    void Start ()
    {
        
    }
    void Update ()
    {
        Hea = health;
        Pow = Power;
        HeaText.text = Hea.ToString();
        PowText.text = Pow.ToString();
    }

    public void OnTriggerEnter (Collider other) 
    {
        if (other.tag == "BullBoss")
        {
            
            Power -=25;
            Destroy(other.gameObject);
            if (Power <= 0)
            {
                Power = 0;
            }
            if (Power >= 100)
            {
                Power = 100;
            }
            
        }
        if (other.tag == "Bot")
        {
            health -= 15;
            Destroy(other.gameObject);
            if (health <= 0)
            {
                health = 0;
                //Destroy(gameObject);
            }
            if (health >= 100)
            {
                health = 100;
            }
            
            //GameManager.instance.DecreaseLife();
        }
        
        
    }
     
}
