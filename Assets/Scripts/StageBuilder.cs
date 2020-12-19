using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageBuilder : MonoBehaviour
{

    public int length = 8;
    public int width = 8;
    public GameObject buildingBLock;

    private Vector3[] groundBlockPositions;

    private void Awake()
    {
        GenerateGroundBlockPositions();
    }

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateGroundBlockPositions()
    {

        float x = 0.0f;
        float z = 0.0f;

        groundBlockPositions = new Vector3[length*width];

        for(int i = 0; i < width*length; i++)
        {
            groundBlockPositions[i] = new Vector3(x, 0.0f, z);

            x += (x < length - 1) ? 1 : -(x);
            z += (x == length - 1) ? 1 : 0;

        }

    }

}
