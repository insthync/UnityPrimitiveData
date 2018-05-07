using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseSimplePrimitiveData : MonoBehaviour
{
    public Color gizmosColor = Color.magenta;
    public abstract Vector3 GetRandomPosition();
}
