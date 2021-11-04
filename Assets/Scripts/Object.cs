using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public Points mypoints;  
    // Start is called before the first frame update
    void Start()
    {
        Cursor. visible = true;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public GameObject object_found;
    public GameObject object_list;
    public GameObject next_object;

    void OnMouseDown()
    {
       if(Input.GetMouseButtonDown(0))
       {
        if(object_list.transform.position.y > -5)
        {
         object_found.SetActive(false);
         object_list.SetActive(false);
         mypoints.points++;
         Vector3 p = object_list.transform.position;
         if(mypoints.points == 1)
         {
           next_object = GameObject.FindGameObjectWithTag("1");
           next_object.transform.position = p;
         }
         if(mypoints.points == 2)
         {
           next_object = GameObject.FindGameObjectWithTag("2");
           next_object.transform.position = p;
         }
        }
       }   
    }
}
