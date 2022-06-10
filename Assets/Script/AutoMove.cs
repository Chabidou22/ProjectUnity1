using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))] // outil nécessaire quand il y'a un lien très fort entre les deux composants - doit être là pour que le composant fonctionne

public class AutoMove : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Movement")] // affichage pour faciliter et embellir le script
    [Tooltip("Speed move")]

    public Vector3 speed = new Vector3(0.5f,0f,0f);

    public Vector3 speedRotation;

    [Header("data")]

    [Range(0,10)] public int intensity;

    [HideInInspector]public int a;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>(); //GetComponent : chercher le composant concernant rigidbody

        if(rb.velocity == Vector3.zero){
        transform.position += speed * Time.deltaTime;}
    }
}
