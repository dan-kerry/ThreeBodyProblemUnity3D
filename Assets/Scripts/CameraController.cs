using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject[] Bodies;
    private GameObject keyObject;
    void Start()
    {
        StartCoroutine(InitialiseBodyArray());
    }

    IEnumerator InitialiseBodyArray()
    {
        yield return new WaitForSeconds(0.25f);
        Bodies = GameObject.FindGameObjectsWithTag("Body");
        float maxMass = 0;
        foreach (GameObject body in Bodies)
        {
            if (body.transform.localScale[0] > maxMass) {
                maxMass = body.transform.localScale[0];
                keyObject = body;
            }
        }
        transform.parent = keyObject.transform;   
    }

    void Update()
    {
        
        
    }
}
