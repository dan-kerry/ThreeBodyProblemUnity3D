using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static BodyConfig;

public class Spawner : MonoBehaviour
{

    public int BodyCount;
    public GameObject BodyPrefab;
    


    private static BodyConfig B1 = new BodyConfig(new Vector3(-0.97000436f, 0.24308753f, 0f), new Vector3(0.466203685f, 0.43236573f, 0f),new Vector3(1f, 1f, 1f));
    private static BodyConfig B2 = new BodyConfig(new Vector3(0.97000436f, -0.24308753f, 0f), new Vector3(0.466203685f, 0.43236573f, 0f),new Vector3(1f, 1f, 1f));
    private static BodyConfig B3 = new BodyConfig(new Vector3(0f, 0f, 0f), new Vector3(-0.93240737f, -0.86473146f, 0f),new Vector3(1f, 1f, 1f));
    private BodyConfig[] Figure8 = new BodyConfig[3] {B1, B2, B3};
 

    
    
void SetStart() {
    foreach (BodyConfig config in Figure8) {
        GameObject newObject = Instantiate(BodyPrefab, config.Position, Quaternion.identity);

    }
   
    // Start is called before the first frame update
    void Start()
    {
        //RandomStart();
        SetStart();
    }

void RandomStart() {
    for (int i = 0; i < BodyCount; i++) {
    GameObject newObject = Instantiate(BodyPrefab, Vector3.zero, Quaternion.identity);
    }


    

}

}

}
