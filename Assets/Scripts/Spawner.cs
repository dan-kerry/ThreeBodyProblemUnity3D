using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private GameObject s;
    private ArrayList myNodes;
    public int BodyCount;
    public GameObject BodyPrefab;
   
    // Start is called before the first frame update
    void Start()
    {
        myNodes = new ArrayList();
       
        for (int i = 0; i < BodyCount; i++)
        {
            Vector3 randomLocation = new Vector3 (Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f));
            float BodyScale = Random.Range(2f, 4.0f);
            
            GameObject localBody = Instantiate(BodyPrefab, randomLocation, Quaternion.identity);
            localBody.transform.localScale = new Vector3 (BodyScale, BodyScale, BodyScale);
            
            //myNodes.Add(s);}
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

}
