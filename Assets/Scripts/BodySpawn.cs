using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodySpawn : MonoBehaviour
{
    public GameObject RegisterA;
  
    Rigidbody rb;
    private List <GameObject> RelevantList;
    
    void Start()
    {
        //RandomSpawn();
        //SetSpawn();
        RegisterA = GameObject.FindWithTag("GameController");
        RegisterA.GetComponent<ObjectRegister>().AllBodies.Add(gameObject);
    }
    void FixedUpdate() {

        
    }

    void RandomSpawn() {
            Vector3 randomLocation = new Vector3 (Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f));
            Vector3 randomForce = new Vector3 (Random.Range(-4f, 4f), Random.Range(-4f, 4f), Random.Range(-4f, 4f));
            float BodyScale = Random.Range(2f, 6.0f);
            transform.localScale = new Vector3(BodyScale, BodyScale, BodyScale);
            transform.localPosition = randomLocation;
            rb = GetComponent<Rigidbody>();
            rb.mass = BodyScale;
            rb.velocity = randomForce;
    }

    void SetSpawn(Vector3 Location, Vector3 Force, float Scale){
            Vector3 randomLocation = new Vector3 (Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f));
            Vector3 randomForce = new Vector3 (Random.Range(-4f, 4f), Random.Range(-4f, 4f), Random.Range(-4f, 4f));
            float BodyScale = Random.Range(2f, 6.0f);
            transform.localScale = new Vector3(BodyScale, BodyScale, BodyScale);
            transform.localPosition = randomLocation;
            rb = GetComponent<Rigidbody>();
            rb.mass = BodyScale;
            rb.velocity = randomForce;
    }

}
