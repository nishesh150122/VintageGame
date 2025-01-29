using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LightGlow : MonoBehaviour
{
    public GameObject[] Img;
    public int indx=0;

    public float waitTime;
/*    public Component _GO;
*/    // Start is called before the first frame update
    void Start()
    {
        while (indx <= 12)
        {
            StartCoroutine(ImageColorCoroutine());
        }
    }

    private IEnumerator ImageColorCoroutine()
    {
        Img[indx].transform.GetComponent<Image>().color = Color.black;
        yield return new WaitForSeconds(waitTime);
        Img[indx].transform.GetComponent<Image>().color = Color.white;
        indx++;
    }

    // Update is called once per frame
    void Update()
    {
        

        /*if (indx==0)
        {
            print("hello");
            Img[indx].transform.GetComponent<Image>().color=Color.black;
            StartCoroutine(hold());
        }
        else if (indx == 1)
        {
            print("hello1");
            Img[indx-1].transform.GetComponent<Image>().color = Color.white;
            Img[indx].transform.GetComponent<Image>().color = Color.black;
            StartCoroutine(hold());
        }
        else if (indx == 2)
        {
            print("hello2");
            Img[indx - 1].transform.GetComponent<Image>().color = Color.white;
            Img[indx].transform.GetComponent<Image>().color = Color.black;
            StartCoroutine(hold());
        }
        else if (indx == 3)
        {
            print("hello3");
            Img[indx - 1].transform.GetComponent<Image>().color = Color.white;
            Img[indx].transform.GetComponent<Image>().color = Color.black;
            StartCoroutine(hold());
        }
        else if (indx == 4)
        {
            print("hello4");
            Img[indx - 1].transform.GetComponent<Image>().color = Color.white;
            Img[indx].transform.GetComponent<Image>().color = Color.black;
            StartCoroutine(hold());
        }
        else if (indx == 5)
        {
            print("hello5");
            Img[indx - 1].transform.GetComponent<Image>().color = Color.white;
            Img[indx].transform.GetComponent<Image>().color = Color.black;
            StartCoroutine(hold());
        }
        else if (indx == 6)
        {
            print("hello6");
            Img[indx - 1].transform.GetComponent<Image>().color = Color.white;
            Img[indx].transform.GetComponent<Image>().color = Color.black;
            StartCoroutine(hold());
        }
        else if (indx == 7)
        {
            print("hello7");
            Img[indx - 1].transform.GetComponent<Image>().color = Color.white;
            Img[indx].transform.GetComponent<Image>().color = Color.black;
            StartCoroutine(hold());
        }
        else if (indx == 8)
        {
            print("hello8");
            Img[indx - 1].transform.GetComponent<Image>().color = Color.white;
            Img[indx].transform.GetComponent<Image>().color = Color.black;
            StartCoroutine(hold());
        }
        else if (indx == 9)
        {
            print("hello9");
            Img[indx - 1].transform.GetComponent<Image>().color = Color.white;
            Img[indx].transform.GetComponent<Image>().color = Color.black;
            StartCoroutine(hold());
        }
        else if (indx == 10)
        {
            print("hello10");
            Img[indx - 1].transform.GetComponent<Image>().color = Color.white;
            Img[indx].transform.GetComponent<Image>().color = Color.black;
            StartCoroutine(hold());
        }
        else if (indx == 11)
        {
            print("hello11");
            Img[indx - 1].transform.GetComponent<Image>().color = Color.white;
            Img[indx].transform.GetComponent<Image>().color = Color.black;
            StartCoroutine(hold());
        }
        else if(indx == 12)
        {
            print("hello12");
            Img[indx - 1].transform.GetComponent<Image>().color = Color.white;
            Img[indx].transform.GetComponent<Image>().color = Color.black;
        }
        else
        {
            Img[indx - 1].transform.GetComponent<Image>().color = Color.white;
            *//*indx = 0;*//*
        }*/
    }
}
