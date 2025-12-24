using UnityEngine;

public class Vehicle : MonoBehaviour
{
    private float speed = 10f;
    private float weight;
    protected float Weight {
        get { return weight; }
        set {
            if(value <= 0){
                throw new System.ArgumentException("Weight must be greater than zero. Setting to default value of 1.");

            }
            else
            {
                weight = value;   
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
        Move();
    }
    public virtual void Move()
    {
        speed = getSpeed();
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    protected float getSpeed()
    {
        if(weight > 0){
            return speed/weight;
        }
        else
        {
            return speed;
        }
    }
}
