using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookingth : MonoBehaviour
{
    public Transform player;
    public float turningspeed;
    float xrotation;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mousex = Input.GetAxis("Mouse X") * turningspeed * Time.deltaTime;
        float mousey = Input.GetAxis("Mouse Y") * turningspeed * Time.deltaTime;
        player.Rotate(Vector3.up * mousex);

        xrotation -= mousey;
        xrotation = Mathf.Clamp(xrotation, -90, 90);
        transform.localRotation = Quaternion.Euler(xrotation, 0f, 0f);
    }
}
