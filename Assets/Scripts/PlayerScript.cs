using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 1f;

    public Light2D playerLight;

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 tilt = Input.acceleration;
        rb.AddForce(tilt*speed);
    }
}
