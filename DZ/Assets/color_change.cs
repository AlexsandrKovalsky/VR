using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_change : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj2;
    public GameObject obj3;
    public bool isGrounded;
    public bool its_green;
    // Start is called before the first frame update
    void Start()
    {
        obj.GetComponent<Renderer>().material.color = Color.grey;
        obj2.GetComponent<Renderer>().material.color = Color.grey;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            its_green = !its_green;
            if (its_green == true)
            {
                obj.GetComponent<Renderer>().material.color = Color.green;
            }
            else
            {
                obj.GetComponent<Renderer>().material.color = Color.grey;
            }

            if (its_green == false)
            {
                obj2.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                obj2.GetComponent<Renderer>().material.color = Color.grey;
            }

            obj3.GetComponent<Rigidbody>().AddForce(new Vector3(0, 200, 0));
            isGrounded = false;
        }
    }
}
