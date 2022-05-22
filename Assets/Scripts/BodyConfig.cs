using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyConfig : MonoBehaviour
{
    public Vector3 Position;
    public Vector3 Force;
    public Vector3 Scale;

    public BodyConfig(Vector3 pos, Vector3 forc, Vector3 scal) {
        Position = pos;
        Force = forc;
        Scale = scal;
    }
}
