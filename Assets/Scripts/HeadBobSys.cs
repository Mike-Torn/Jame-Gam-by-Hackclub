using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HeadBobSys : MonoBehaviour
{
    [Range(0.001f, 0.01f)]
    public float Amount = 0.002f;

    [Range(1f, 30f)]
    public float Frequency = 10f;

    [Range(10f, 100f)]
    public float Smooth = 50f;

    public static HeadBobSys Instance;

    Vector3 StartPos;


    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
        StartPos = transform.localPosition;

    }

    // Update is called once per frame
    void Update()
    {
        CheckForHeadBobTrigger();
        ResetHeadBob();
    }

    private void CheckForHeadBobTrigger()
    {
        float inputMagnitude = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).magnitude;

        if (inputMagnitude > 0)
        {
            StartHeadBob();
        }
        
    }

    private Vector3 StartHeadBob()
    {
       Vector3 pos = Vector3.zero;
       pos.y += Mathf.Lerp(pos.y, Mathf.Sin(Time.time * Frequency) * Amount * 1.4f, Smooth * Time.deltaTime);
       pos.x += Mathf.Lerp(pos.x, Mathf.Cos(Time.time * Frequency / 2f) * Amount * 1.6f, Smooth * Time.deltaTime);
       transform.localPosition += pos;

       return pos;
    }

    private void ResetHeadBob()
    {
        if (transform.localPosition == StartPos) return;
        
        transform.localPosition = Vector3.Lerp(transform.localPosition, StartPos, 1 * Time.deltaTime);
    }
}
