using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerDeath : MonoBehaviour
{
    [SerializeField] float deathdelay = 6.0f;
    [SerializeField] GameObject rb;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, deathdelay);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
