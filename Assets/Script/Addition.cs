using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class Addition : MonoBehaviour
{
    public GameObject Dis;
    public string inpvalue;
    public TMP_InputField Inpfield;
    public static string buttonco;

    public void sum()
    {
/*        addclick();
*/      buttonco = gameObject.transform.GetChild(0).GetComponent<TMP_Text>().text;
        inpvalue = Inpfield.text;
        print("inp ko value " + inpvalue);
        Inpfield.text = "";
        print("inp text ko value " + Inpfield.text);
        
    }
    public void clear()
    {
        Inpfield.text = null;
    }
    private void Start()
    {
        Dis = GameObject.Find("Display");
        Inpfield = Dis.gameObject.GetComponent<TMP_InputField>();
    }
}
