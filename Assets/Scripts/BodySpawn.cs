using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodySpawn : MonoBehaviour
{
    Rigidbody rb;
 
    void Start()
    {
            Vector3 randomForce = new Vector3 (Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f));
            float BodyScale = Random.Range(2f, 6.0f);
            transform.localScale = new Vector3(BodyScale, BodyScale, BodyScale);
            
            rb = GetComponent<Rigidbody>();
            rb.mass = BodyScale;
            rb.velocity = randomForce;
    }

}
