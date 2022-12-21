using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicReticle : MonoBehaviour
{
    public float rotSpeed = 1.0f;
    public float sineOffset = 0.1f;
    public float sineScale = 0.6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotates the reticle
        transform.Rotate(Vector3.up * (rotSpeed * Time.deltaTime));
        
        // Scales the reticle up and down over time based on sine
        // sineOffset is added to the calculated sine value over time to offset the value
        Vector3 scaleVec = new Vector3(Mathf.Sin(Time.time) * sineScale + sineOffset,
                                        Mathf.Sin(Time.time) * sineScale + sineOffset,
                                        Mathf.Sin(Time.time) * sineScale + sineOffset);
        transform.localScale = scaleVec;
    }
}
