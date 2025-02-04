using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public GameObject DisBox;
    public TMP_InputField DisBoxComp;
    public AudioSource AudioKoSource;
    public AudioClip AudioKoclip;
   

    public void buttonclick()
    {
        AudioKoSource.PlayOneShot(AudioKoclip);
        string inp, inp2;
        inp2 = DisBoxComp.text;
        inp = gameObject.transform.GetChild(0).GetComponent<TMP_Text>().text;
        print("inp " + inp);
        DisBoxComp.text = inp;
        inp2 = inp2 + inp;
        DisBoxComp.text = inp2;

    }

    public void Start()
    {
        DisBox = GameObject.Find("Display");
        DisBoxComp = DisBox.gameObject.GetComponent<TMP_InputField>();
    }
}
