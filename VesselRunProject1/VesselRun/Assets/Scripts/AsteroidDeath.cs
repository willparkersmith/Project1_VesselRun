using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDeath : MonoBehaviour
{
    [SerializeField] float deathdelay = 6.0f; //delay before asteroids will auto despawn
    [SerializeField] Rigidbody rb;
    private Vector3 rotation;

    //audio source and SFX
    //[SerializeField] AudioSource audio;
    //[SerializeField] AudioClip explode;
    private void Awake()
    {
        //audio.GetComponent<AudioSource>();
    }

    void Start()
    {
        //destroys game object after the deathdelay variable reaches 0
        rb = GetComponent<Rigidbody>();
        Destroy(this.gameObject, deathdelay);
        rotation = new Vector3(0.0f, 0.0f, Random.Range(100.0f, 25.0f));
    }

    private void FixedUpdate()
    {
        Quaternion deltaRotation = Quaternion.Euler(rotation * Time.fixedDeltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //on collision with an instance of lazer, this object will destroy
        if(collision.gameObject.name == "Lazer(Clone)")
        {
            //audio.PlayOneShot(explode);
            Destroy(this.gameObject);
            //Debug.Log("Asteroid Hit");
        }
    }
}
