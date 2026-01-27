using UnityEngine;
using System.Collections;

public class BuildingDropperScript : MonoBehaviour
{
    // Building prefabs 
    public GameObject[] buildings;
    public GameObject currentBuilding;
    
    // Properties
    public float limit = 8f;
    
    void Start()
    {
        
    }

    void Awake()
    {
        currentBuilding = buildings[0];
        StartCoroutine(SpawnBuilding());
    }
    

    private IEnumerator SpawnBuilding()
    {
        
        // Choose a building
        int buildingNumber = Random.Range(0, buildings.Length);
        currentBuilding = buildings[buildingNumber];
        
        // Choose Location
        float x = Random.Range(-limit, limit);
        Vector3 buildingPosition = new Vector3(x, transform.position.y, 0);

        Instantiate(currentBuilding, buildingPosition, transform.rotation);

        yield return new WaitForSeconds(1.5f);
        StartCoroutine(SpawnBuilding());


    }
    
    
}
