using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllySpawner : MonoBehaviour
{
    public GameObject allyDrone;
    private float posX;
    float nextSpawn;
    Vector3 whereToSpawn;

    private float totalAllyDroneCount;

    public GameObject parentDrone;
    // Start is called before the first frame update
    void Start()
    {
        totalAllyDroneCount = 3;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawn (float droneCount)
    {   
        Debug.Log(totalAllyDroneCount);
        if ( totalAllyDroneCount > droneCount)
        {
             for (int i = 0; i < totalAllyDroneCount - droneCount; i++)
                
                {   

                    GameObject missingDrone = GameObject.Find("AllyDrone");
                    if( missingDrone != null)         
                    Destroy (missingDrone);
                }

        }
        else if (totalAllyDroneCount < droneCount)
        {
            for (int i = 0; i <  droneCount - totalAllyDroneCount; i++)
                
                {            
                    whereToSpawn = new Vector3 (parentDrone.transform.position.x , parentDrone.transform.position.y ,parentDrone.transform.position.z);
                    Debug.Log(whereToSpawn);
                    whereToSpawn.Set(0 + 5 * i, 0+ 5 * i, 0);
                    GameObject AllyDrone = Instantiate(allyDrone, whereToSpawn, Quaternion.identity);
                }

        }

        totalAllyDroneCount = droneCount;
        Debug.Log(totalAllyDroneCount);

    }
}
