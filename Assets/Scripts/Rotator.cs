using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public GameObject target;
    public float rotationSpeed = 5;
    public float moveSpeed = 0.1f;
   // private Rigidbody rb;
   // private Vector3 mousePosition;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime);

       Vector3 vectorToTarget = target.transform.position - transform.position;
        
    }
}


