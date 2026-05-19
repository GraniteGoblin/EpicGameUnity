using Unity.VisualScripting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateText : MonoBehaviour
{
    public static TMPro.TMP_Text viewText;
    public static bool runTextPrint;
    public static int charCount;
    [SerializeField] string transferText;
    [SerializeField] int internalCount;

    // Update is called once per frame
    void Update()
    {
        internalCount = charCount;
        charCount = GetComponent<TMPro.TMP_Text>().text.Length;
        transferText = viewText.text;
        viewText.text = "";
        StartCoroutine(RollText());
    }
    IEnumerator RollText()
    {
        foreach (char c in transferText)
        {
            viewText.text += c;
            yield return new WaitForSeconds(0.05f);

        }




    }




}
