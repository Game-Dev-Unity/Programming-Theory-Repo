using UnityEngine;

public class Vehicle : MonoBehaviour
{
    private int year;
    protected int Year
    {
        get { return year; }
        set { 
            if(value < 0)
            {
                Debug.LogError("Year cannot be negative.");
            }
            else
            {
                year = value;
            }
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    protected virtual void Move()
    {
        
    }
    
}
