using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nBodyCalculation : MonoBehaviour
{
    public GameObject RegisterA;
    private List <GameObject> RegisterComplete;
    private List <GameObject> otherBodies;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        CreateBodyList();
        rb = GetComponent<Rigidbody>();
        //ValidateBodyList();
    }
    
    void CreateBodyList() {
        RegisterA = GameObject.FindWithTag("GameController");
        RegisterComplete = RegisterA.GetComponent<ObjectRegister>().AllBodies;
        otherBodies = new List<GameObject>();
        foreach (GameObject item in RegisterComplete) {
            if (item.GetInstanceID() != gameObject.GetInstanceID()){
            otherBodies.Add(item);  
            }
        }
    }
    void ValidateBodyList(){
        foreach (GameObject body in otherBodies) {
            Debug.Log("This Body is: " + gameObject.transform.localScale + "  Other Body: " + body.transform.localScale);
        }
    }

    Vector3 solveMotion(){
        Vector3 result = Vector3.zero;
        for (int i = 0; i < otherBodies.Count; i++) {
            //Debug.Log(otherBodies[i].transform.localScale[0]);
            result = result + -9.8f * otherBodies[i].transform.localScale[0] * (gameObject.transform.localPosition - otherBodies[i].transform.localPosition) / 
                MathF.Pow((MathF.Sqrt(
                MathF.Pow(gameObject.transform.localPosition[0] - otherBodies[i].transform.localPosition[0] ,2.0f) + 
                MathF.Pow(gameObject.transform.localPosition[1] - otherBodies[i].transform.localPosition[1] ,2.0f) +
                MathF.Pow(gameObject.transform.localPosition[2] - otherBodies[i].transform.localPosition[2] ,2.0f))), 3.0f);
        }
        return result;
        //Debug.Log("SB: " +result);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 DeltaV = solveMotion();
        rb.AddForce(DeltaV, ForceMode.Acceleration);
    }

    void OnDrawGizmos()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, (transform.position+solveMotion()*2));
    }
}
