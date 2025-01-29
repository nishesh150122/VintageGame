using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    GameObject game;
    public GameObject[] objectko;
    public Vector3[] positionobjectko;
    public float obkospeed = 5f;
    public bool a = false;
    int i = 0;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    IEnumerator waittime()
    {
        Vector3 al;
        a = true;
        al = objectko[i].transform.position;
        LeanTween.move(gameObject, al, 2f);
        yield return new WaitForSeconds(2.1f);
        i++;
        a = false;
    }
    /*public void okok()
    {
        
    }
*/

    // Update is called once per frame
    void Update()
    {
        if(!a)
        {
            StartCoroutine(waittime());
        }
    }
}
