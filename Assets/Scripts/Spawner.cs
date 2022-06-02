using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static BodyConfig;


public class Spawner : MonoBehaviour
{

    public int BodyCount;
    public  List <BodyData> Initials;
    public GameObject BodyPrefab;
    Rigidbody rb;
    Rigidbody rb2;
    Rigidbody rb3;
    public List <BodyData> InitialBodyList;
    

void SetStart() {
            /*
            GameObject newObject1 = Instantiate(BodyPrefab, Vector3.zero, Quaternion.identity);
            Vector3 randomLocation = new Vector3 (-0.97000436f, 0.24308753f, 0f);
            Vector3 randomForce = new Vector3 (0.466203685f, 0.43236573f, 0f);
            float BodyScale = 0.1f;
            newObject1.transform.localScale = new Vector3(BodyScale, BodyScale, BodyScale);
            newObject1.transform.localPosition = randomLocation;
            rb = newObject1.GetComponent<Rigidbody>();
            rb.mass = BodyScale;
            rb.velocity = randomForce;

            GameObject newObject2 = Instantiate(BodyPrefab, Vector3.zero, Quaternion.identity);
            Vector3 randomLocation2 = new Vector3 (0.97000436f, -0.24308753f, 0f);
            Vector3 randomForce2 = new Vector3 (0.466203685f, 0.43236573f, 0f);
            float BodyScale2 = 0.1f;
            newObject2.transform.localScale = new Vector3(BodyScale2, BodyScale2, BodyScale2);
            newObject2.transform.localPosition = randomLocation2;
            rb2 = newObject2.GetComponent<Rigidbody>();
            rb2.mass = BodyScale2;
            rb2.velocity = randomForce2;

            GameObject newObject3 = Instantiate(BodyPrefab, Vector3.zero, Quaternion.identity);
            Vector3 randomLocation3 = new Vector3 (0f, 0f, 0f);
            Vector3 randomForce3 = new Vector3 (-0.93240737f, -0.86473146f, 0f);
            float BodyScale3 = 0.1f;
            newObject3.transform.localScale = new Vector3(BodyScale3, BodyScale3, BodyScale3);
            newObject3.transform.localPosition = randomLocation3;
            rb3 = newObject3.GetComponent<Rigidbody>();
            rb3.mass = BodyScale3;
            rb3.velocity = randomForce3;
            */

}
     

    
    // Start is called before the first frame update
    void Start()
    {
        InitialBodyList = GetComponent<XmlParse>().InitialBodyList;
        foreach (BodyData body in InitialBodyList)
        {
            Rigidbody rb;
            GameObject newObject = Instantiate(BodyPrefab, Vector3.zero, Quaternion.identity);
            Vector3 randomLocation = new Vector3 (body.XPosition, body.YPosition, body.ZPosition);
            Vector3 randomForce = new Vector3 (body.XVelocity, body.YVelocity, body.ZVelocity);
            newObject.transform.localScale = new Vector3(body.Mass, body.Mass, body.Mass);
            newObject.transform.localPosition = randomLocation;
            rb = newObject.GetComponent<Rigidbody>();
            rb.mass = body.Mass;
            rb.velocity = randomForce;
        }

        SetStart();
    }

void RandomStart() 
{
    for (int i = 0; i < BodyCount; i++) {
    GameObject newObject = Instantiate(BodyPrefab, Vector3.zero, Quaternion.identity);
}

    



}}


