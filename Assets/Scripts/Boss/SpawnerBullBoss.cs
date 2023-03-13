using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBullBoss : MonoBehaviour {

    [SerializeField]float spawnInterval;
    //public GameObject Boss;
    public GameObject BullBoss;
    public Transform bullBoss;
    Vector3 myVector ;
    float x;
    float y;
    float z;


    public static SpawnerBullBoss instance;

    

    // Use this for initialization
    void Start () {
        //Boss = GameObject.Find ("Boss(Clone)") ;

        //SpawnCandy();
        
        StartSpawningBullBoss();

	}
	
	// Update is called once per frame
	void Update () 
    {

	}


    public void SpawnCandy()
    {
        myVector = bullBoss.transform.position ;
        Instantiate(BullBoss).transform.position = myVector;
        //Portal.instance.StartBullDestroy();
    }



    IEnumerator SpawnBullBoss()
    {
        yield return new WaitForSeconds(3f);

        while (true)
        {
            SpawnCandy();

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    public void StartSpawningBullBoss()
    {
        StartCoroutine(SpawnBullBoss());
    }

    public void StopSpawningBullBoss()
    {
        StopCoroutine(SpawnBullBoss());
    }


}
