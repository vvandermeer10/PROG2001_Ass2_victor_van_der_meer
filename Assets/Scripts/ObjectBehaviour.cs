using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehaviour : MonoBehaviour
{
    public GameObject person;
    public float value;
    public Vector3 sizeChange;
    private Vector3 position;

    public void Start()
    {
        position = new Vector3(person.transform.position.x,
            person.transform.position.y, person.transform.position.z);
    }

    public void MoveRight()
    {
        //value += 0.1f;
        //person.transform.position = new Vector3(value,0,0);
        person.transform.position = new Vector3(person.transform.position.x + value,
            person.transform.position.y, person.transform.position.z);
    }
    public void MoveLeft()
    {
        person.transform.position = new Vector3(person.transform.position.x - value,
            person.transform.position.y, person.transform.position.z);
    }

    public void RotateOjectRight()
    {
        person.transform.Rotate(0, 10f, 0);
    }

    public void RotateOjectLeft()
    {
        person.transform.Rotate(0, -10f, 0);
    }

    public void GrowObject()
    {
        person.transform.localScale = person.transform.localScale + sizeChange; 
    }

    public void ShrinkObject()
    {
        person.transform.localScale = person.transform.localScale - sizeChange;
    }

    public void ResetObject()
    {
        person.transform.position = position;
        person.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        person.transform.localScale = Vector3.one;
    }


}
