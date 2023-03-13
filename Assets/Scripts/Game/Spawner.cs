using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    //[SerializeField]
    //float maxX;
    float x;
    float y;
    float z;

    [SerializeField]
    float spawnInterval = 5;
    private float minspawnInterval = 2.0f;

    public GameObject Boss;
    public GameObject Bot;
    int BotClon = 0;


    public static Spawner instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start () {

        //SpawnCandy();

        StartSpawningCandies();
        StartCoroutine(SpeedIncrease());

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private IEnumerator SpeedIncrease()
    {
        yield return new WaitForSeconds(1);
        if (spawnInterval == minspawnInterval)
        {
            spawnInterval -= 0.05f;
            StartCoroutine(SpeedIncrease());
        }
        
    }


    void SpawnCandy()
    {
        x = Random.Range(-16, 16);
        y = 1.5f;
        z = Random.Range(-16, 16);
        Instantiate(Bot).transform.position = new Vector3 (x,y,z) ;
        
        BotClon ++;
        if (BotClon == 4)
        {
            Instantiate(Boss).transform.position = new Vector3 (x,y,z) ;
            BotClon-= 4;
        }
    }



    IEnumerator SpawnCandies()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            SpawnCandy();

            yield return new WaitForSeconds(spawnInterval);
        }
    }
    

    public void StartSpawningCandies()
    {
        StartCoroutine(SpawnCandies());
    }

    public void StopSpawningCandies()
    {
        StopCoroutine(SpawnCandies());
    }

}
