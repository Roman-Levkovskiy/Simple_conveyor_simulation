using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Product : MonoBehaviour
{
    public enum productType
    {
        Red,
        Green,
        Blue
    }
    public productType type;
    void Start()
    {
        type = (productType)Random.Range(0, 3);
        switch (type)
        {
            case productType.Red:
                GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            case productType.Green:
                GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            case productType.Blue:
                GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
        }
    }
}
