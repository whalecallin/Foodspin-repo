using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarbFood : Food
{
 public override string GetFoodType()
 {
     return "Carbs";
 }

   public override void RotateInPlace()
    {
        transform.Rotate(Vector3.up *(RotationSpeed * Time.deltaTime), Space.World);
    }
}
