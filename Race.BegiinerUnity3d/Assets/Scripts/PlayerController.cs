using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     public float speed = 5.0f;
    public float turnspeed;
    public float horizontalInput;
    public float ForwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        ForwardInput = Input.GetAxis("Vertical");
        
      //  transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward*Time.deltaTime*speed*ForwardInput)  ;
     //   transform.Translate(Vector3.right * Time.deltaTime * turnspeed*horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontalInput);
    }
}
