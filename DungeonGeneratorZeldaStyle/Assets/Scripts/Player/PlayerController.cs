using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float Speed = 10;
    private int _MoveDirection = 0;
    private int _AimDirection = 0;
    private Quaternion test = new Quaternion();
    
    // Update is called once per frame
    void Update()
    {
        //up
        if (Input.GetKey("w") && !Input.GetKey("a") && !Input.GetKey("s") && !Input.GetKey("d"))
        {
            Moving();
            test.eulerAngles = new Vector3(0, 0, 0);
        }

        // up-left
        if (Input.GetKey("w") && Input.GetKey("a") && !Input.GetKey("s") && !Input.GetKey("d"))
        {
            Moving();
            test.eulerAngles = new Vector3(0, -45, 0);
        }

        //left
        if (!Input.GetKey("w") && Input.GetKey("a") && !Input.GetKey("s") && !Input.GetKey("d"))
        {
            Moving();
            test.eulerAngles = new Vector3(0, -90, 0);
        }

        //left-down
        if (!Input.GetKey("w") && Input.GetKey("a") && Input.GetKey("s") && !Input.GetKey("d"))
        {
            Moving();
            test.eulerAngles = new Vector3(0, -135, 0);
        }

        //down
        if (!Input.GetKey("w") && !Input.GetKey("a") && Input.GetKey("s") && !Input.GetKey("d"))
        {
            Moving();
            test.eulerAngles = new Vector3(0, 180, 0);
        }

        //down-right
        if (!Input.GetKey("w") && !Input.GetKey("a") && Input.GetKey("s") && Input.GetKey("d"))
        {
            Moving();
            test.eulerAngles = new Vector3(0, 135, 0);
        }

        //right
        if (!Input.GetKey("w") && !Input.GetKey("a") && !Input.GetKey("s") && Input.GetKey("d"))
        {
            Moving();
            test.eulerAngles = new Vector3(0, 90, 0);
        }

        //right-up
        if (Input.GetKey("w") && !Input.GetKey("a") && !Input.GetKey("s") && Input.GetKey("d"))
        {
            Moving();
            test.eulerAngles = new Vector3(0, 45, 0);
        }
        


        transform.rotation = Quaternion.Slerp(transform.rotation, test, 0.05f);
    }


    private void Moving()
    {
        transform.position += transform.forward * Speed * Time.deltaTime;
    }
}
