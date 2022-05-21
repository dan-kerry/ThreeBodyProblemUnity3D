using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nBodyCalculation : MonoBehaviour
{
    public GameObject RegisterA;
    private List <GameObject> RegisterComplete;
    private List <GameObject> otherBodies;
    // Start is called before the first frame update
    void Start()
    {
        CreateBodyList();
        ValidateBodyList();
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

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
