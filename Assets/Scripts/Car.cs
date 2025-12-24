using UnityEngine;

public class Car : Vehicle
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
        Drive();
    }
    void Drive()
    {
        // Driving logic for the car
        
    }
}
