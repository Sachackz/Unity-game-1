using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public CharacterController mover;
    public float spped;
    public LayerMask ground;
    bool ingrounded;
    public Transform groundcheker;
    float gravity = -9.81f;
    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * spped;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime* spped;

        Vector3 move = Vector3.forward * vertical + Vector3.right * horizontal;
        mover.Move(move);

        //velocity.y += gravity * Time.deltaTime;
        //mover.Move(velocity * Time.deltaTime);    

        ingrounded = Physics.CheckSphere(groundcheker.position, 0.4f, ground);
        //if (ingrounded && velocity.y < 0.2) 
        //{
        //    velocity.y -= -2;
        //}

    }
}
