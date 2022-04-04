using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProteinFood : Food
{
    void Start()
    {
        //RotationSpeed = 5;
    }
 public override string GetFoodType()
 {
     return "Protein";
 }

   public override void RotateInPlace()
    {
        transform.Rotate(Vector3.up *(RotationSpeed * Time.deltaTime), Space.World);
    }
}
