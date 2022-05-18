using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProblemController : MonoBehaviour
{
    
    public GameObject[] Bodies;
    private Vector3[] outputVectors = new Vector3[3];
    //private Rigidbody rb;
    void Start()
    {
        StartCoroutine(InitialiseBodyArray());
    }

    IEnumerator InitialiseBodyArray()
    {
        yield return new WaitForSeconds(0.1f);
        Bodies = GameObject.FindGameObjectsWithTag("Body");
    }

    Vector3[] Solver(GameObject[] BodyArray) {
        //Todo: This needs to be scaled so that it can work on n > 2. For 2 bodies only it may require a seperate solver solution.
    

        int ArrayLen = BodyArray.Length;
    
        outputVectors[0] = -9.8f * BodyArray[1].transform.localScale[0] * (BodyArray[0].transform.localPosition - BodyArray[1].transform.localPosition) / 
                MathF.Pow((MathF.Sqrt(
                MathF.Pow(BodyArray[0].transform.localPosition[0] - BodyArray[1].transform.localPosition[0] ,2.0f) + 
                MathF.Pow(BodyArray[0].transform.localPosition[1] - BodyArray[1].transform.localPosition[1] ,2.0f) +
                MathF.Pow(BodyArray[0].transform.localPosition[2] - BodyArray[1].transform.localPosition[2] ,2.0f))), 3.0f) -

                9.8f * BodyArray[2].transform.localScale[0] * (BodyArray[0].transform.localPosition - BodyArray[2].transform.localPosition) / 
                MathF.Pow((MathF.Sqrt(
                MathF.Pow(BodyArray[0].transform.localPosition[0] - BodyArray[2].transform.localPosition[0] ,2.0f) + 
                MathF.Pow(BodyArray[0].transform.localPosition[1] - BodyArray[2].transform.localPosition[1] ,2.0f) +
                MathF.Pow(BodyArray[0].transform.localPosition[2] - BodyArray[2].transform.localPosition[2] ,2.0f))), 3.0f)
                ;
            
            Rigidbody rb = BodyArray[0].GetComponent<Rigidbody>();
            rb.AddForce(outputVectors[0], ForceMode.Acceleration);
            
        outputVectors[1] = -9.8f * BodyArray[2].transform.localScale[0] * (BodyArray[1].transform.localPosition - BodyArray[2].transform.localPosition) / 
                MathF.Pow((MathF.Sqrt(
                MathF.Pow(BodyArray[1].transform.localPosition[0] - BodyArray[2].transform.localPosition[0] ,2.0f) + 
                MathF.Pow(BodyArray[1].transform.localPosition[1] - BodyArray[2].transform.localPosition[1] ,2.0f) +
                MathF.Pow(BodyArray[1].transform.localPosition[2] - BodyArray[2].transform.localPosition[2] ,2.0f))), 3.0f) -

                9.8f * BodyArray[0].transform.localScale[0] * (BodyArray[1].transform.localPosition - BodyArray[0].transform.localPosition) / 
                MathF.Pow((MathF.Sqrt(
                MathF.Pow(BodyArray[1].transform.localPosition[0] - BodyArray[0].transform.localPosition[0] ,2.0f) + 
                MathF.Pow(BodyArray[1].transform.localPosition[1] - BodyArray[0].transform.localPosition[1] ,2.0f) +
                MathF.Pow(BodyArray[1].transform.localPosition[2] - BodyArray[0].transform.localPosition[2] ,2.0f))), 3.0f)
                ;

                Rigidbody rb1 = BodyArray[1].GetComponent<Rigidbody>();
                rb1.AddForce(outputVectors[1], ForceMode.Acceleration);
        
        outputVectors[2] = -9.8f * BodyArray[0].transform.localScale[0] * (BodyArray[2].transform.localPosition - BodyArray[0].transform.localPosition) / 
                MathF.Pow((MathF.Sqrt(
                MathF.Pow(BodyArray[2].transform.localPosition[0] - BodyArray[0].transform.localPosition[0] ,2.0f) + 
                MathF.Pow(BodyArray[2].transform.localPosition[1] - BodyArray[0].transform.localPosition[1] ,2.0f) +
                MathF.Pow(BodyArray[2].transform.localPosition[2] - BodyArray[0].transform.localPosition[2] ,2.0f))), 3.0f) -

                9.8f * BodyArray[1].transform.localScale[0] * (BodyArray[2].transform.localPosition - BodyArray[1].transform.localPosition) / 
                MathF.Pow((MathF.Sqrt(
                MathF.Pow(BodyArray[2].transform.localPosition[0] - BodyArray[1].transform.localPosition[0] ,2.0f) + 
                MathF.Pow(BodyArray[2].transform.localPosition[1] - BodyArray[1].transform.localPosition[1] ,2.0f) +
                MathF.Pow(BodyArray[2].transform.localPosition[2] - BodyArray[1].transform.localPosition[2] ,2.0f))), 3.0f)
                ;

                Rigidbody rb2 = BodyArray[2].GetComponent<Rigidbody>();
                rb2.AddForce(outputVectors[2], ForceMode.Acceleration);
        
        for (int i = 0; i > BodyArray.Length; i++) {
            
            List<int> tempListA = BodyArray.ToList();
           

          
            


        }
        
        return outputVectors;
    }


    void BodyMover(Vector3[] dvs){

    for (int i = 0; i < Bodies.Length; i++) 
        {
        Rigidbody rb = Bodies[i].GetComponent<Rigidbody>();
        rb.AddForce(dvs[i], ForceMode.Acceleration);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Bodies.Length > 0) {
        Solver(Bodies);
        }
    }
}
