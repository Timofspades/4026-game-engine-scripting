using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloScript : MonoBehaviour {

    int counter = 0; //Create a counter, starting at zero

    string originalText = "Counting Down: ";
    string continuedText = "";

    float floatDemo = 10.0f / 3.0f;
    double doubleDemo = 10.0 / 3.0;

    // Start is called before the first frame update
    void Start()
    {
        continuedText = "Float value: " + floatDemo + "\n" + "Double Value: " + doubleDemo;

        ChangeText(originalText + "\n" + continuedText);
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        ChangeText(originalText + counter + "\n" + continuedText);
    }

    private void ChangeText(string text){

        GetComponent<Text>().text = text;

    }
}
