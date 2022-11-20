using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Vessel : MonoBehaviour
{
    //All sprites sourced from https://opengameart.org/content/2d-spaceships
    private float VesselMoveSpeed = 30.0f; //Modifer for move speed
    public Rigidbody rb;
    public Collider collider;
    private float hInput; //Input for unities default horizontal keybinds
    public bool IsAlive = true; //Bool toggles Life and Death Functions
    public bool SheildActive = false; //WORK IN PROGRESS. LINKED TO POWERUP CLASS. NOT FUNCTIONAL

    //UI: RESTART, AND A GAME OVER YOU HAVEW DIED
    [SerializeField] TextMeshProUGUI Deadui;
    [SerializeField] TextMeshProUGUI Restartui;


    //[SerializeField] Asteroid asteroidscript;

    //AUDIO SOIURCES AND SFX
    [SerializeField] AudioSource audio;
    [SerializeField] AudioClip Dead;
    [SerializeField] AudioClip DeathExplosion;


    //AUDIO SOURCE SELECTION
    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    //initialize vessel rigidbody
    //sets UI intial boolen values
    //Fixes Z postion -WORK IN PROGRESS-
    void Start()
    {
        Deadui.enabled = false;
        Restartui.enabled = false;
        rb = GetComponent<Rigidbody>();
        collider = GetComponent<Collider>();
        rb.constraints = RigidbodyConstraints.FreezePositionZ;
    }

    //Input for fixed update movment
    void Update()
    {
        hInput = Input.GetAxis("Horizontal") * VesselMoveSpeed;
    }



    //here the actual movment is calculated
    //Input form the player only reaches this movment if the player is still alive
    private void FixedUpdate()
    {
        if (IsAlive)
        {
            rb.MovePosition(this.transform.position + this.transform.right * hInput * Time.fixedDeltaTime);
        }
    }

    //Checks for collisions with Asteroids and Powerup
    //POWER UP IS NON FUNCTIONAL
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "PowerUp")
        {
            Debug.Log("SheildActive");
            SheildActive = true;
            collider.enabled = !collider.enabled;
        }

        if (collision.gameObject.name == "Asteroid(Clone)")
        {
            Debug.Log("I'M HIT");
            SheildCheck();
        }
    }

    //executes when a collision is detected
    //Was to be used for a sheild powerup object NOT CYRRENTLY IMPLIMENTED
    private void SheildCheck()
    {
        if (SheildActive == false)
        {
            Deadui.enabled = true;
            IsAlive = false;
            Debug.Log("I'M DEAD");
            new WaitForSecondsRealtime(2);
            Restartui.enabled = true;
            audio.PlayOneShot(Dead);
            audio.PlayOneShot(DeathExplosion);
        }
    }


}
