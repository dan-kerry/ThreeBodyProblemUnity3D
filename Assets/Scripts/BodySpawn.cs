using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodySpawn : MonoBehaviour
{
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
           
            Vector3 randomForce = new Vector3 (Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
            float BodyScale = Random.Range(2f, 4.0f);
            
            //GameObject localBody = Instantiate(BodyPrefab, randomLocation, Quaternion.identity);
            //localBody.transform.localScale = new Vector3 (BodyScale, BodyScale, BodyScale);
            rb = GetComponent<Rigidbody>();
            rb.AddForce(randomForce, ForceMode.Impulse);
    }

}
