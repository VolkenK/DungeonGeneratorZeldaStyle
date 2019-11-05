using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControll : MonoBehaviour
{


    [SerializeField] private float turnSpeed;
    private Quaternion test = new Quaternion();

    // Update is called once per frame
    void Update()
    {



        //up
        if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            test.eulerAngles = new Vector3(0, 0, 0);
        }

        //up-left
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            test.eulerAngles = new Vector3(0, -45, 0);
        }

        //left
        if (!Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            test.eulerAngles = new Vector3(0, -90, 0);
        }

        //left-down
        if (!Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            test.eulerAngles = new Vector3(0, -135, 0);
        }

        //down
        if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            test.eulerAngles = new Vector3(0, 180, 0);
        }

        //down-right
        if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            test.eulerAngles = new Vector3(0, 135, 0);
        }

        //right
        if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            test.eulerAngles = new Vector3(0, 90, 0);
        }

        //right-up
        if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            test.eulerAngles = new Vector3(0, 45, 0); 
        }


        transform.rotation = Quaternion.Slerp(transform.rotation, test, 0.10f);
    }
    
}
