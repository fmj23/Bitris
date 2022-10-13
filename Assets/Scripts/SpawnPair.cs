using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPair : MonoBehaviour
{
    public bool canSpawn;
    public GameObject onBit;
    public GameObject offBit;
    Board myBoard;
    public GameObject bitLeft = null;
    public GameObject bitRight = null;

    private void Awake()
    {
        canSpawn = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        myBoard = Board.instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (canSpawn)
        {
            SpawnNext();

            canSpawn = false;
        }
    }

    private void SpawnNext()
    {
        int typeLeft = Random.Range(0, 2);
        int typeRight = Random.Range(0, 2);
        Debug.Log("Pair:" + typeLeft + " " + typeRight);
        if (typeLeft == 0)
        {
            bitLeft = Instantiate(offBit, new Vector3(0, myBoard.yNextLeft, myBoard.zNextLeft), Quaternion.identity);
        }
        else
        {
            bitLeft = Instantiate(onBit, new Vector3(0, myBoard.yNextLeft, myBoard.zNextLeft), Quaternion.identity);
        }
        if (typeRight == 0)
        {
            bitRight = Instantiate(offBit, new Vector3(0, myBoard.yNextLeft, myBoard.zNextLeft + 2.5f), Quaternion.identity);
        }
        else
        {
            bitRight = Instantiate(onBit, new Vector3(0, myBoard.yNextLeft, myBoard.zNextLeft + 2.5f), Quaternion.identity);
        }
    }
}
