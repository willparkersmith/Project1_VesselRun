using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] GameObject Asteroidet;
    public float AsteroidSpeed = -5.0f; //NEED TO INCRIMENT
    private bool StopSpawning = false; //Bool that when true stops the spawning
    public float spawnTime; //initial delay from game start to first spawn
    public float spawnDelay; //delayfrom after fisrt, this will slowly decrease over time

    private void Start()
    {
        //Refrence https://www.youtube.com/watch?v=1h2yStilBWU
        //InvokeRepeating Lets us call SpawnAsteroid on a delay
        //this delay slowly shrinks as the Method is called
        InvokeRepeating("SpawnAsteroid", spawnTime, spawnDelay);
    }

    private void Update()
    {
        if(Timer.StopAteroidsFlag == true)
        {
            StopSpawning = true;
        }
    }

    public void SpawnAsteroid()
    {
        //Below are the intialzers fro each clone
        //each clone will have a random x. and Y range from here it will fall
        //NEED TO ADD SPIN AND SIZE CHANGE
        //POSSIBLE FOR ASTEROIDS TO IGNORE HITTING EACH OTHER?
        GameObject newAsteroid = Instantiate(Asteroidet, this.transform.position + new Vector3(Random.Range(-6, 6), Random.Range(-1, 5), 0), this.transform.rotation);
        Rigidbody AsteroidRB = newAsteroid.GetComponent<Rigidbody>();
        AsteroidRB.velocity = this.transform.up * AsteroidSpeed;
        spawnDelay -= 0.4f;

        //If True Stops calling this method
        if (StopSpawning)
        {
            CancelInvoke();
        }
    }

}
