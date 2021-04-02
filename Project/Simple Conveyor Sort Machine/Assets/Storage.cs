using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour
{
    public int countProducts;
    public Product.productType type;
    void Start()
    {
        transform.parent.name = "Storage " + type.ToString();
        countProducts = 0;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Product")
        {
            ++countProducts;
            Destroy(collision.gameObject);
        }
    }
}
