using UnityEngine;

public class BuildingScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float bottomLimit = -8f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= bottomLimit)
        {
            Destroy(this.gameObject);
        }
    }
}
