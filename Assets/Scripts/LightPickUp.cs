using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PIckUp : MonoBehaviour
{
    public float lightRadius = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            PlayerScript playerScript = collision.GetComponent<PlayerScript>();
            if (playerScript != null)
            {
                Light2D light = playerScript.playerLight;
                light.pointLightInnerRadius = light.pointLightInnerRadius + lightRadius; 
                light.pointLightOuterRadius = light.pointLightOuterRadius + lightRadius;
                Destroy(gameObject);
            }
            else
            {
                //No existe dentro del player
            }
        }
    }
}
