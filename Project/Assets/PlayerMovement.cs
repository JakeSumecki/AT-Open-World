using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private float speed = 10.0f;


    private float pitch = 0.0f;
    private float yaw = 0.0f;
    private float rotSpeed = 5.0f;

    // Use this for initialization
    void Start ()
    {
        print(Input.GetAxis("Vertical"));
    }


	// Update is called once per frame
	void Update ()
    {
        movePlayer();
        rotPlayer();

    }

    void movePlayer()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime* speed, 0.0f, Input.GetAxis("Vertical") * Time.deltaTime* speed);
    }

    void rotPlayer()
    {
        yaw += rotSpeed * Input.GetAxis("Mouse X");
        pitch -= rotSpeed * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
