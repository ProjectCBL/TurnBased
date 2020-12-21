using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageBuilder : MonoBehaviour
{

    public int length = 8;
    public int width = 8;
    public GameObject buildingBLock;
    public GameObject startingPoint;

    private Vector3[] groundBlockPositions;

    private void Awake()
    {
        GenerateGroundBlockPositions();
        PlaceGroundStartingPoint();
    }

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    private IEnumerator CreateGroundFloor(){

        for(int i = 0; i < groundBlockPositions.Length; i++){
            Instantiate(buildingBLock, groundBlockPositions[i], Quaternion.identity, startingPoint.transform);
            yield return new WaitForSeconds(0.25f);
        }

    }

    private void PlaceGroundStartingPoint(){
        startingPoint.transform.position = new Vector3(length/2, 0.0f, width/2);
    }

    private void GenerateGroundBlockPositions()
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
