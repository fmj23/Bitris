using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public static Board instance { get; private set; }

    public static float leftLimit = 0f;
    public static float rightLimit = 17.5f;
    public static float bottomLimit = 0f;
    public static float topLimit = 27.5f;
    public static float zSpawn1 = 7.5f;
    public static float zSpawn2 = 10f;
    public static float ySpawn = 27.5f;
    // 32.5
    //16
    public float zNextLeft = 16f;
    public float yNextLeft = 32.5f;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
