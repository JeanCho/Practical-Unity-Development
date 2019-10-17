using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTank : MonoBehaviour
{


    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 movement = this.transform.forward * speed * Time.deltaTime;

        this.transform.position += movement;
    }
}
