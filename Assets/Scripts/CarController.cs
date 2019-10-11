using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private Rigidbody carBody;
    private float horzInput;

    [SerializeField]
    private GameObject frontWheelL;
    [SerializeField]
    private GameObject frontWheelR;

    private const float MAXSPEED = 200;
    // Start is called before the first frame update
    void Start()
    {
        carBody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horzInput = Input.GetAxis("Horizontal");
        if(Input.GetButton("Gas"))
        {        
            if(carBody.velocity.magnitude < MAXSPEED)
            {   
                carBody.AddForce(transform.right * 10);
            }   
        }


        frontWheelL.transform.RotateAround(frontWheelL.transform.position, frontWheelL.transform.forward, 45 * Time.deltaTime * horzInput * 10); 
        

        
        
    }
}
