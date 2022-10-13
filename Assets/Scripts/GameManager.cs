using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public GameObject board;
    private SpawnPair spawnScript;
    public GameObject bit1;
    public GameObject bit2;
    private bool startRound = false;

    [SerializeField] private Transform startLeft;
    [SerializeField] private Transform startRight;

    // Start is called before the first frame update
    void Start()
    {
        startLeft.position = new Vector3(0f, Board.topLimit, Board.leftLimit + (2.5f * 3f));
        startRight.position = new Vector3(0f, Board.topLimit, Board.leftLimit + (2.5f * 4f));
        spawnScript = board.GetComponent<SpawnPair>();
        spawnScript.canSpawn = true;

        // Some countdown timer can start this in the real game
        startRound = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(startRound)
        {
            Debug.Log("Ready to move pair");
            bit1 = spawnScript.bitLeft;
            bit2 = spawnScript.bitRight;
            // Release these from the 'Next'
            spawnScript.bitLeft = null;
            spawnScript.bitRight = null;
            // Spawn the "next"
            spawnScript.canSpawn = true;
            // Move these to the start location
            MoveToStart(bit1, bit2);
            Debug.Log("Ready to continue game");

            startRound = false;
        }
    }

    void MoveToStart(GameObject bit1, GameObject bit2)
    {
        bit1.transform.position = startLeft.position;
        bit2.transform.position = startRight.position;
    }
}
