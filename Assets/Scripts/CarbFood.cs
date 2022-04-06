using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarbFood : Food // INHERITANCE
{

    CarbFood()
    {
        m_foodType = "Carbs";
        RotationSpeed = 20f;
    }

   public override void RotateInPlace() // POLYMORPHISM
    {
        transform.Rotate(Vector3.up *(RotationSpeed * Time.deltaTime), Space.World);
    }
}
