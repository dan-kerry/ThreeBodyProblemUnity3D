using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static BodyConfig;

public class Spawner : MonoBehaviour
{

    public int BodyCount;
    public GameObject BodyPrefab;
   
    // Start is called before the first frame update
    void Start()
    
    {
        for (int i = 0; i < BodyCount; i++)
        {
            //Vector3 randomLocation = new Vector3 (Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f));
            GameObject newObject = Instantiate(BodyPrefab, Vector3.zero, Quaternion.identity);
            
    }

    void Figure8() {

    }

}

}
