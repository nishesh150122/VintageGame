using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrollkolagi : MonoBehaviour
{
    public bool onclick = false;
    public bool onclickR = false;
    public int i = 0,j=0;

    public void ScrollLKoLagiho()
    {
        onclick = true;
        onclickR = false;
        i++;
        if(i%2==0)
        {
            onclick = false;
        }
    }
    public void ScrollRKoLagiho()
    {
        onclickR = true;
        onclick = false;
        j++;
        if (j % 2 == 0)
        {
            onclickR = false;
        }
    }
}
