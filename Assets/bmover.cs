using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bmover : MonoBehaviour
{
    public float spinspeed = 180.0f;
    public float motionmagnitude = 0.1f;

    public bool isspin = true;
    public bool ismoving = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isspin)
        {
            gameObject.transform.Rotate(Vector3.up * spinspeed * Time.deltaTime);
        }
        if (ismoving)
        {
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionmagnitude);
        }
    }
}
