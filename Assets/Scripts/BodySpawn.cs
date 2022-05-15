using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodySpawn : MonoBehaviour
{
    Rigidbody rb;
 
    void Start()
    {
            Vector3 randomForce = new Vector3 (Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
            float BodyScale = Random.Range(2f, 4.0f);
            transform.localScale = new Vector3(BodyScale, BodyScale, BodyScale);
            
            rb = GetComponent<Rigidbody>();
            rb.mass = BodyScale;
            rb.velocity = randomForce;
    }

}
