using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using UnityEngine;

public class XmlParse : MonoBehaviour
{
     
    public static BodyData ImportXML()
    {
        //string filePath = Path.Combine(Application.persistentDataPath, "Scenarios/Figure8.xml"); 
        string filePath = "/Users/dankerry/Documents/Projects/GPS/GPS/Assets/Scripts/Scenarios/Figure8.xml";
        BodyData LoadData()
        {
            if (File.Exists(filePath))
            {
                Debug.Log("File Found!");
                string fileText = File.ReadAllText(filePath);
                XmlSerializer serializer = new XmlSerializer(typeof(BodyData));
                using (StringReader reader = new StringReader(fileText))
                {
                    return (BodyData)(serializer.Deserialize(reader)) as BodyData;
                }
            }
        return null;
          
    } 
        return null;
    }
}

public class BodyData
{
    public float InitialXPosition;
    public float InitialYPosition;
    public float InitialZPosition;
    public float Mass;
    public float InitialXVelocity;
    public float InitialYVelocity;
    public float InitialZVelocity;
   
}