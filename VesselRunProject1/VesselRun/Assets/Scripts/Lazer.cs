using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    [SerializeField] GameObject LazerBlast; //Prfab we will be instantiating
    public float LazerSpeed = 18.0f; //Velocity of bullets
    private bool IsFiring; //Bool toggles when firing
    [SerializeField] AudioSource audio; //SFX Source for this class
    [SerializeField] AudioClip Shoot; //SFX for this class

    //Audio source selection
    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    //Sets is firing bool to switch when the left mouse is clicked
    private void Update()
    {
        IsFiring |= Input.GetMouseButtonDown(0);
    }

    //Triggers single shot function and single SFX noiseClip
    private void FixedUpdate()
    {
        if (IsFiring)
        {
            audio.PlayOneShot(Shoot);
            LazerShot();
        }
    }

    //Function Containing Our Shooting.
    //All shots are prfabs cloned =and placed several floating point ubove our player transform
    private void LazerShot()
    {
        GameObject newAsteroid = Instantiate(LazerBlast, this.transform.position + new Vector3(0, 1.5f, 0), this.transform.rotation);
        Rigidbody AsteroidRB = newAsteroid.GetComponent<Rigidbody>();
        AsteroidRB.velocity = this.transform.up * LazerSpeed;
        IsFiring = false;
    }

    //BELOW IS TBD. WAS WORK IN PROGRESS EXPLODING MECHANIC
    //LIKE THE ACOMAPNYING POWERUP CLASS THIS IS NON-FUNCTIONAL CURRENTLY
    /*private void LazerSplitShot()
    {
        GameObject newAsteroid = Instantiate(LazerBlast, this.transform.position + new Vector3(0, 1.5f, 0), this.transform.rotation);
        GameObject newAsteroidr = Instantiate(LazerBlast, this.transform.position + new Vector3(0, 1.5f, 0), this.transform.rotation + new Vector3(0.0f,0.0f,45.0f);



        Rigidbody AsteroidRB = newAsteroid.GetComponent<Rigidbody>();
        AsteroidRB.velocity = this.transform.up * LazerSpeed;
        IsFiring = false;
    }*/

}
