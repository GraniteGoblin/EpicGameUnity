using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prototype_scene_1 : MonoBehaviour
{
    public GameObject FadeScreenIn;
    public GameObject TextBox;
    void Start()
    {
        StartCoroutine(EventStarter());
    }

    
    IEnumerator EventStarter()
    {
        yield return new WaitForSeconds(2);
        FadeScreenIn.SetActive(false);
        TextBox.SetActive(true);
    }



}
