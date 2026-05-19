using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prototype_scene_1 : MonoBehaviour
{
    public GameObject FadeScreenIn;
    public GameObject TextBox;
    

    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextlength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainTextObject;
    [SerializeField] GameObject NextButton; 
    int eventPosition = 0;

    void Update()
    {
        textLength = CreateText.charCount;
    }
    void Start()
    {
        StartCoroutine(EventStarter());
    }

    
    IEnumerator EventStarter()
    {
        //fade in from black
        yield return new WaitForSeconds(2);
        FadeScreenIn.SetActive(false);

        // Create text box 
        yield return new WaitForSeconds(5);
        mainTextObject.SetActive(true);
        textToSpeak = "";
        TextBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        CreateText.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == textToSpeak.Length);
        yield return new WaitForSeconds(0.5f);
        //NextButton.SetActive(true);
       // TextBox.SetActive(true);


    }



}
