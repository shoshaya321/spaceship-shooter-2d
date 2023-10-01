using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject MeteorToSpawn;
    float timer = 1f;
    public float timerUp = 2f;
    public float timerDown = 0.2f; 

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            MeteorSpawn();
            timer = Random.Range(timerDown, timerUp);
        }
        
    }
     void MeteorSpawn()
    {
        Vector3 placeToSpawn = new Vector3(Random.Range(-5, 5), 3, 0);
        Instantiate(MeteorToSpawn,placeToSpawn, MeteorToSpawn.transform.rotation);
    }

   
}
