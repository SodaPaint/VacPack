using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class chain : MonoBehaviour
{


    [SerializeField] GameObject _parent;
    
    //this code creates a time difference bewtween this object and its supoosed position


    public Vector3 positionToMoveTo;
    public Vector3 ChildsOffset;

    private void Awake()
    {
        
    }
    private void Update()
    {

        positionToMoveTo = _parent.transform.position;
        StartCoroutine(LerpPosition(positionToMoveTo, .04f));
    }
    IEnumerator LerpPosition(Vector3 targetPosition, float duration)
    {
        float time = 0;
        Vector3 startPosition = transform.position;
        while (time < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
    }


   


}
