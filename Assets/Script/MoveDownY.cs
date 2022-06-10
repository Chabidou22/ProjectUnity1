using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownY : MonoBehaviour
{
    public float speed = 1f;
    public GameObject maxYPosition;
    public float minPosition = 0f;
    private float factor = -1f;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, speed * factor, 0) * Time.deltaTime;
        if (transform.position.y <= minPosition){
            factor = 1f;
        }
        else if (maxYPosition != null && transform.position.y >= maxYPosition.transform.position.y){
            factor = -1f;
        }
    }
}
