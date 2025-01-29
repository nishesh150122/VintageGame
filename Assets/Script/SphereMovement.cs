using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class SphereMovement : MonoBehaviour
{
    public float speed = 10f; // Constant velocity speed
    public Vector3 initialDirection = new Vector3(1f, 1f, 0f); // Desired initial direction
    private Vector3 direction; // Direction of movement
    public bool hoho = false;
    /* public GameObject UIhaleko;
     public GameObject[] AO;*/
    public AudioSource aud;
    public AudioClip audtype1,audtype2,audtype3;


    private void Start()
    {
        /*UIhaleko = GameObject.Find("UIBachhako");*/
/*        UIhaleko.SetActive(false);
*/
        // Initialize the direction with the specified initialDirection
        direction = initialDirection;
        
    }

    private void Update()
    {
        // Move the sphere with constant velocity
        transform.position = transform.position + direction * speed * Time.deltaTime;
    }
    IEnumerator laaba()
    {
        yield return  new WaitForSeconds(2f);
        
    }
    void jitneharne()
    {
        transform.position = new Vector3(0f, 0f, 10f);
        speed = 0f;
        StartCoroutine(laaba());
        hoho = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        aud.PlayOneShot(audtype1);
        if(!hoho)
        {
            if (collision.gameObject.name == "Box1")
            {
                aud.PlayOneShot(audtype2);
                jitneharne();
            }
            if (collision.gameObject.tag == "obstacle")
            {
                Destroy(collision.gameObject);
                speed = speed + 0.75f;
            }
            else if ((GameObject.FindWithTag("obstacle")) == null)
            {
                aud.PlayOneShot(audtype3);
                jitneharne();
            }
            else
            {
            }
            // Calculate the new direction after collision (reflect)
            direction = Vector3.Reflect(direction, collision.contacts[0].normal);
        }
    }

        
}
