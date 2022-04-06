using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Food : MonoBehaviour
{
    [SerializeField]protected float RotationSpeed = 3;

    private float _currentScale = InitScale;
    private const float TargetScale = 1.1f;
    private const float InitScale = 1f;
    private const int FramesCount = 200;
    private const float AnimationTimeSeconds = 1;
    private float _deltaTime = AnimationTimeSeconds/FramesCount;
    private float _dx = (TargetScale - InitScale)/FramesCount;
    private bool _upScale = true;

    public abstract void RotateInPlace();
    
    protected string m_foodType;

    public string foodType // ENCAPSULATION
    {
        get{return m_foodType;}
        set {foodType = m_foodType;}
    }

    private void OnMouseOver()
    {
        UIMain.Instance.UpdateFoodInfo(gameObject.name, foodType);
        Debug.Log("On Mouse Over");
        StopCoroutine("Shrink");
        StartCoroutine("Enlarge");
        RotateInPlace();
    }

    private void OnMouseExit()
    {
        StopCoroutine("Enlarge");
        StartCoroutine("Shrink");
        Debug.Log(" Exit");
        UIMain.Instance.UpdateFoodInfo();
    }

    private IEnumerator Enlarge()
    {
        while (_currentScale!=TargetScale)// originally only checks for _upScale
         {
             _currentScale += _dx;
             if (_currentScale > TargetScale)
             {
                 _upScale = false;
                 _currentScale = TargetScale;
             }
             transform.localScale = Vector3.one * _currentScale;
             yield return new WaitForSeconds(_deltaTime);
         }
    }

    private IEnumerator Shrink()
    {
        while (!_upScale)
         {
             _currentScale -= _dx;
             if (_currentScale < InitScale)
             {
                 _upScale = true;
                 _currentScale = InitScale;
             }
             transform.localScale = Vector3.one * _currentScale;
             yield return new WaitForSeconds(_deltaTime);
         }
    }
}
