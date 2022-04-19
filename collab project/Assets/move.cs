using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Public playercontroller pc;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float X = Input.getaxis("Horizontal");
        float z = Input.getaxis("Vertical");
        Vector3 move = vector3.forward * X + vector3.right * z;
        pc.Move(move * speed * time.deltatime());
    }
}
