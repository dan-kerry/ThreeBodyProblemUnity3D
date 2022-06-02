using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.Globalization;
using System;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using UnityEngine;

public class XmlParse : MonoBehaviour
{
    XDocument xmlDoc;
    IEnumerable<XElement> items; 
    List <BodyData> data = new List <BodyData>(); 

    void Start() 
    {
        LoadXML();
        StartCoroutine ("AssignData");
        Debug.Log(data[0].Mass);

    }
    void LoadXML()
    {
        xmlDoc = XDocument.Load("/Users/dankerry/Documents/Projects/GPS/GPS/Assets/Scripts/Scenarios/Figure8.xml"); 
    }

    IEnumerator AssignData()
    {
        IEnumerable<XElement> elements = from el in xmlDoc.Descendants("body") select el;  
        foreach (XElement el in elements) 
        {
            float XPos = (float)Convert.ToDouble(el.Element("InitialXPosition").Value);
            float YPos = (float)Convert.ToDouble(el.Element("InitialYPosition").Value);
            float ZPos = (float)Convert.ToDouble(el.Element("InitialZPosition").Value);
            float Mas = (float)Convert.ToDouble(el.Element("Mass").Value);
            float XVel = (float)Convert.ToDouble(el.Element("InitialXVelocity").Value);
            float YVel = (float)Convert.ToDouble(el.Element("InitialYVelocity").Value);
            float ZVel = (float)Convert.ToDouble(el.Element("InitialZVelocity").Value);

            data.Add(new BodyData(XPos, YPos, ZPos, Mas, XVel, YVel, ZVel));                    
        }
        yield return null;
    }
}




public class BodyData
{
    public float XPosition, YPosition, ZPosition, Mass, XVelocity, YVelocity, ZVelocity;
    
    public BodyData (float InitialXPosition, float InitialYPosition, float InitialZPosition, float xMass,float InitialXVelocity,float InitialYVelocity,float InitialZVelocity)
    {
        XPosition = InitialXPosition;
        YPosition = InitialYPosition;
        ZPosition = InitialZPosition;
        Mass = xMass;
        XVelocity = InitialXVelocity;
        YVelocity = InitialYVelocity;
        ZVelocity = InitialZVelocity;
        
    }
}
