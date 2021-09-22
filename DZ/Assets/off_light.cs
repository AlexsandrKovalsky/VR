using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class off_light : MonoBehaviour
{
    
    private Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Tab))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}
