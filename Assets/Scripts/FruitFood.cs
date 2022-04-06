using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitFood : Food // INHERITANCE
{
    void Start()
    {
        m_foodType = "Fruit";
    }

    public override void RotateInPlace() // POLYMORPHISM
    {
        transform.Rotate(Vector3.down *(RotationSpeed * Time.deltaTime), Space.World);
    }
    
    
}
