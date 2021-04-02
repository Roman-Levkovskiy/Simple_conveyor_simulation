using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortCenter : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Product")
        {
            Vector3 pos = collision.transform.position;
            switch (collision.gameObject.GetComponent<Product>().type)
            {
                case Product.productType.Red:
                    collision.transform.position = new Vector3(pos.x + 0.6f, pos.y, pos.z+0.05f);
                    break;
                
                case Product.productType.Green:
                    collision.transform.position = new Vector3(pos.x, pos.y, pos.z + 0.6f);
                    break;

                case Product.productType.Blue:
                    collision.transform.position = new Vector3(pos.x - 0.6f, pos.y, pos.z + 0.05f);
                    break;
            }
        }
    }
}
