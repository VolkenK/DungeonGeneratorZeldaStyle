using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject BulletPrefab;
    private int seconds = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && seconds == 0)
        {
            Instantiate(BulletPrefab, this.transform.position, this.transform.rotation);
            seconds = 1;
            StartCoroutine("timer");
            
        }
    }

    private IEnumerator timer()
    {
        yield return new WaitForSeconds(0.1f);
        seconds = 0;
    }
}
