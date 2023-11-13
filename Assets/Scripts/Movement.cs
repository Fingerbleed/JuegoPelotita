using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tilt = Input.acceleration * Time.deltaTime;
        tilt = Quaternion.Euler(90,0,0)*tilt;
        rb.AddForce(tilt*speed);
    }
}