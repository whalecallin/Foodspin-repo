using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProteinFood : Food // INHERITANCE
{
    ProteinFood()
    {
        m_foodType = "Protein";
        RotationSpeed = 10f;
    }

   public override void RotateInPlace() // POLYMORPHISM
    {
        transform.Rotate(Vector3.up *(RotationSpeed * Time.deltaTime), Space.World);
    }
}
