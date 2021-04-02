using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject product;
    public GameObject canvas;

    public GameObject redStorage;
    public GameObject greenStorage;
    public GameObject blueStorage;
    private Text redText;
    private Text greenText;
    private Text blueText;
    private void Start()
    {
        redText = canvas.transform.Find("RedText").GetComponent<Text>();
        greenText = canvas.transform.Find("GreenText").GetComponent<Text>();
        blueText = canvas.transform.Find("BlueText").GetComponent<Text>();
        StartCoroutine(productCreation());
    }

    IEnumerator productCreation()
    {
        while(true)
        {
            Instantiate(product, new Vector3(0, 0.5f, -4.5f), new Quaternion());
            yield return new WaitForSeconds(1);
        }
    }

    private void Update()
    {
        redText.text = "Red: " + redStorage.transform.Find("Cube").GetComponent<Storage>().countProducts;
        greenText.text = "Green: " + greenStorage.transform.Find("Cube").GetComponent<Storage>().countProducts;
        blueText.text = "Blue: " + blueStorage.transform.Find("Cube").GetComponent<Storage>().countProducts;
    }
}
