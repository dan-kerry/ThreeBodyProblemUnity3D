using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProblemController : MonoBehaviour
{
    
    public GameObject[] Bodies;
    private Vector3[] outputVectors = new Vector3[3];
    public List<GameObject> BodyList = new List<GameObject>();
 
 
         
    //private Rigidbody rb;
    void Start()
    {
        StartCoroutine(InitialiseBodyArray());
    }

    IEnumerator InitialiseBodyArray()
    {
        yield return new WaitForSeconds(0.1f);
        Bodies = GameObject.FindGameObjectsWithTag("Body");
        foreach(GameObject Body in Bodies) {
             BodyList.Add(Body);
         }
    }

    void BodyMover(Vector3[] dvs){

    for (int i = 0; i < Bodies.Length; i++) 
        {
        Rigidbody rb = Bodies[i].GetComponent<Rigidbody>();
        rb.AddForce(dvs[i], ForceMode.Acceleration);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
    }
}
