using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroid : MonoBehaviour
{
    public GameObject Asteroid;
    public float AsteroidSpeed;
    [SerializeField] float spawntime = 5f;
    private bool _isFalling;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*spawntime -= Time.deltaTime;
        if (spawntime < 0)
        {
            spawntime += 5f;
            Instantiate(Asteroid);
        }
        if (transform.position.y <= -20)
        {
            Debug.Log("I am dead");
            Destroy(gameObject);
        }*/
    }
    private void FixedUpdate()
    {
        /*GameObject newAsteroid = Instantiate(Asteroid,this.transform.position + new Vector2(Random.Range(-6, 6), Random.Range(5, 7)), this.transform.rotation);
        Rigidbody2D AsteroidRB = newAsteroid.GetComponent<Rigidbody2D>();
        AsteroidRB.velocity = this.transform.*/
    }
}
