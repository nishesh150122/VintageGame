using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Result : MonoBehaviour
{
    /*public GameObject DisP;
    public GameObject DisM;
    public GameObject DisS;
    public GameObject DisD;*/
    public string FinalResult;
    public string InitialInput;
    public Addition AddObject;
    public Addition MulObject;
    public Addition MinusObject;
    public Addition DivObject;
    public Addition PerObject;
    int firstvalue, secondvalue, res;
    public void Equalto()
    {
        

        string operatorvalue;
        operatorvalue = Addition.buttonco;
        print("BC ko value " + operatorvalue);

        


        if (operatorvalue == "-")
        {
            FinalResult = MinusObject.Inpfield.text;
            print("final ko value " + FinalResult);
            InitialInput = MinusObject.inpvalue;
            print("Initial ko value " + InitialInput);


            firstvalue = int.Parse(FinalResult);
            print("first value " + firstvalue);
            secondvalue = int.Parse(InitialInput);
            print("second value " + secondvalue);
            print("add execute vayo");
            res = secondvalue - firstvalue;
        }
        else if (operatorvalue == "*")
        {
            FinalResult = MulObject.Inpfield.text;
            print("final ko value " + FinalResult);
            InitialInput = MulObject.inpvalue;
            print("Initial ko value " + InitialInput);


            firstvalue = int.Parse(FinalResult);
            print("first value " + firstvalue);
            secondvalue = int.Parse(InitialInput);
            print("second value " + secondvalue);
            print("no");
            res = firstvalue * secondvalue;
        }
        else if (operatorvalue == "+")
        {
            FinalResult = AddObject.Inpfield.text;
            print("final ko value " + FinalResult);
            InitialInput = AddObject.inpvalue;
            print("Initial ko value " + InitialInput);


            firstvalue = int.Parse(FinalResult);
            print("first value " + firstvalue);
            secondvalue = int.Parse(InitialInput);
            print("second value " + secondvalue);
            print("okok");
            res = firstvalue + secondvalue;
        }
        else if (operatorvalue == "/")
        {
            FinalResult = DivObject.Inpfield.text;
            print("final ko value " + FinalResult);
            InitialInput = DivObject.inpvalue;
            print("Initial ko value " + InitialInput);


            firstvalue = int.Parse(FinalResult);
            print("first value " + firstvalue);
            secondvalue = int.Parse(InitialInput);
            print("second value " + secondvalue);
            print("div vayo ");
            res = secondvalue / firstvalue;
        }
        else if(operatorvalue == "%")
        {
            InitialInput = PerObject.inpvalue;
            print("Initial ko value " + InitialInput);


            firstvalue = int.Parse(FinalResult);
            print("first value " + firstvalue);
            secondvalue = int.Parse(InitialInput);
            print("second value " + secondvalue);
            print("div vayo ");
            res = secondvalue / 100;
        }
        else
        {
            print("la error");
            res = firstvalue * secondvalue;

        }


        AddObject.Inpfield.text = res.ToString();
    }
    /*private void Start()
    {
        *//*DisP = GameObject.Find("Plus");
        DisP = GameObject.Find("Multiply");
        DisP = GameObject.Find("-");
        DisP = GameObject.Find("/");*/
        /*if (Addition.buttonco == "+")
        {
            AddObject = 
        }*//*
    }*/

}
