using UnityEngine;

public class Plane : Vehicle
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected override void Move()
    {
        Fly();
    }
    void Fly()
    {
        // Flying logic for the plane
    }
}
