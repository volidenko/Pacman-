using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public float charSpeed=1f;
    public float turnSpeed=50f;
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward*charSpeed*Time.deltaTime);
        if(Input.GetKey(KeyCode.S)
            transform.Translate(Vector3.back*charSpeed*Time.deltaTime);
        if(Input.GetKey(KeyCode.A)
            transform.Translate(Vector3.down*turnSpeed*Time.deltaTime);
        if(Input.GetKey(KeyCode.S)
            transform.Translate(Vector3.up*turnSpeed*Time.deltaTime);
    }
}
