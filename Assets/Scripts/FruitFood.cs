using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitFood : Food
{
    public override string GetFoodType()
    {
        return "Fruits";
    }

    public override void RotateInPlace()
    {
        transform.Rotate(Vector3.down *(RotationSpeed * Time.deltaTime), Space.World);
    }
    
    
}
