using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignColor : MonoBehaviour
{
    [SerializeField] byte r;
    [SerializeField] byte g;
    [SerializeField] byte b;
    // Start is called before the first frame update
    void Start()
    {
        Color32 c = new Color32(r, g, b, 255);
        gameObject.GetComponent<Renderer>().material.color = c;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
