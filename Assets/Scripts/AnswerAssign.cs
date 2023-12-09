using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerAssign : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Text text;
    GameController gc;

    void Start()
    {
        if (gc == null)
        {
            Debug.LogError("GameController is not assigned.");
            return;
        }

        choicemaker();
    }

    void choicemaker()
    {
        int rand = Random.Range(0, 2);
        if (rand == 0)
        {
            BlackCount();
        }
        else
        {
            WhiteCount();
        }
    }

    void BlackCount()
    {

        int bc = gc.black;
        text.text = "How many Black Cats were there in the picture?";
        AssignValueToButton(bc);
    }

    void WhiteCount()
    {
        int wc = gc.white;
        text.text = "How many White Cats were there in the picture?";
        AssignValueToButton(wc);
    }

    void AssignValueToButton(int value)
    {
        int randomButton = Random.Range(1, 5); 

        switch (randomButton)
        {
            case 1:
                button1.GetComponentInChildren<Text>().text = "Count: " + value;
                button1.onClick.AddListener(() => ButtonClicked(value));
                break;
            case 2:
                button2.GetComponentInChildren<Text>().text = "Count: " + value;
                button2.onClick.AddListener(() => ButtonClicked(value));
                break;
            case 3:
                button3.GetComponentInChildren<Text>().text = "Count: " + value;
                button3.onClick.AddListener(() => ButtonClicked(value));
                break;
            case 4:
                button4.GetComponentInChildren<Text>().text = "Count: " + value;
                button4.onClick.AddListener(() => ButtonClicked(value));
                break;
        }
    }

    void ButtonClicked(int value)
    {
        Debug.Log("Button clicked. Value: " + value);
    }
}
