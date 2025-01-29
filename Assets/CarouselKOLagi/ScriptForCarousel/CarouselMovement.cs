using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarouselMovement : MonoBehaviour
{
    public GameObject rightko, leftko;
    public Scrollkolagi sc,lc;
    public Vector3 initpos=Vector3.zero, finalpos=Vector3.zero, scaleobjko;
    public float a = 200f;
    public bool leftkoobj=false, rightkoobj = false;
    private void Start()
    {
        print(sc.onclick);
        scaleobjko = transform.localScale;
    }
    public void CarMov()
    {
        transform.position = Vector3.MoveTowards(transform.position, rightko.transform.position, a);
        if (Vector3.Distance(transform.position, rightko.transform.position) < 0.01f)
        {
            transform.position = leftko.transform.position;
        }
        if (Vector3.Distance(transform.localPosition, new Vector3(-1.337738f, 6.620499f, 0f)) < 10)
        {
            transform.localScale = new Vector3(.5f, 1.5f, 1f);
        }
        else
        {
            transform.localScale = scaleobjko;
        }

    }
    public void CarMovL()
    {
        transform.position = Vector3.MoveTowards(transform.position, leftko.transform.position, a);
        if (Vector3.Distance(transform.position, leftko.transform.position) < 0.01f)
        {
            transform.position = rightko.transform.position;
        }
        if (Vector3.Distance(transform.localPosition, new Vector3(-1.337738f, 6.620499f, 0f)) < 10)
        {
            transform.localScale = new Vector3(.5f, 1.5f, 1f);
        }
        else
        {
            transform.localScale = scaleobjko;
        }
        

    }
    private void Update()
    {
        if (sc.onclick || leftkoobj)
        {
            CarMov();
        }
        if (lc.onclickR || rightkoobj)
        {
            CarMovL();
        }
        if (Input.GetMouseButtonDown(0))
        {
            initpos = Input.mousePosition;
            finalpos = Vector3.zero;
            leftkoobj = false;
            rightkoobj = false;
        }
        if (Input.GetMouseButtonUp(0))
        {
            finalpos = Input.mousePosition;

            float xkopos = initpos.x - finalpos.x;

            if (xkopos > 0f)
            {
                leftkoobj = true;
                print("left tira ");
                rightkoobj = false;
            }
            if (xkopos < 0f)
            {
                rightkoobj = true;
                print("right ko");
                leftkoobj = false;
            }
        }    
    }
    
}