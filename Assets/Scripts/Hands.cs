using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hands : MonoBehaviour
{
    //[SerializeField] private MouseMover mmover;
    [SerializeField] private int mousebtn;
    [SerializeField] private GameObject parent;
    public float posx, posy, posz;
    public bool isclimb;


    private void Update()
    {
        if (!Input.GetMouseButton(mousebtn))
        {
            posx = transform.position.x;
            posy = transform.position.y;
            posz = transform.position.z;
        }
        else if (Input.GetMouseButton(mousebtn) && isclimb)
        {
            transform.position = new Vector3(posx, posy, posz);
        }
        //transform.position = mmover.curPosition;
        //if (parent != null)
        //    transform.SetParent(parent.transform);
    }

    private void OnTriggerStay(Collider other)
    {
        
        if (other.tag == "Climbing")
        {
            Debug.Log("XD");
            isclimb = true;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("!!!");
        isclimb = false;
    }
}
