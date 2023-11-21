using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Rendering.Universal;

public class FlashLight : MonoBehaviour
{
    public float minLightInterval;
    public float maxLightInterval;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(IntervalFlashLight());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator IntervalFlashLight()
    {
        float time = Random.Range(minLightInterval, maxLightInterval);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(time);
        gameObject.GetComponent<Light2D>().intensity = 0.15f;
        Debug.Log("Luz");
        //StartCoroutine(FlashLightDuration());
        yield return new WaitForSeconds(1.0f);
        gameObject.GetComponent<Light2D>().intensity = 0.0f;
        Debug.Log("Oscuro");

        StartCoroutine(IntervalFlashLight());
    }

    IEnumerator FlashLightDuration()
    {
        yield return new WaitForSeconds(1.0f);
    }
}
