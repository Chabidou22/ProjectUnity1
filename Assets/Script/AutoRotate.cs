using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{    
    public Vector3 speed = new Vector3(0f,0.5f,0f);

    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.rotation.eulerAngles;
        rotation += speed;
        transform.rotation = Quaternion.Euler(rotation);
    }
}
