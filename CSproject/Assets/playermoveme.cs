using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermoveme : MonoBehaviour
{
    CharacterController cc;
    public float lr = 2;
    public float gravity = -9.81f;
    bool isgrounded;
    public Transform gc;
    public LayerMask grondmask;
    Vector3 velocity;
    public float jumpheight = 2f;
    public float grounddis = 0.4f;
    public float forwardspeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();   
    }

    // Update is called once per frame
    void Update()
    {
        velocity.z -= forwardspeed * Time.deltaTime;

        isgrounded = Physics.CheckSphere(gc.position, grounddis, grondmask);


        if (velocity.y < 0 && isgrounded)
        {
            velocity.y = -2f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            cc.Move(Vector3.right * lr * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            cc.Move(Vector3.left * lr * Time.deltaTime);
        }

        velocity.y += gravity * Time.deltaTime;
        cc.Move(velocity * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space) && isgrounded)
        {
            velocity.y = Mathf.Sqrt(jumpheight * -2f * gravity);
        }

        
    }
}
