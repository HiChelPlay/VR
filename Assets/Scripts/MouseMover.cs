using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMover : MonoBehaviour
{
    private Vector3 pointScreen;
    private Vector3 offset;
    [SerializeField] private int mousebtn;
    [SerializeField] private Rigidbody obj;
    public Vector3 curPosition;

    [SerializeField] private KinematicObj kobj;
    [SerializeField] private Hands hands;

    private void Update()
    {
        if (!Input.GetMouseButton(mousebtn) && hands.isclimb)
        {
            kobj.iskinematic = false;
            pointScreen = Camera.main.WorldToScreenPoint(transform.position);
            offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, pointScreen.z));
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, pointScreen.z);
            curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
            transform.position = curPosition;
        }
        else if (Input.GetMouseButton(mousebtn))
        {

            kobj.iskinematic = true;
            kobj.Kinematic(false);
        }
        else if (Input.GetMouseButtonUp(mousebtn))
        {
            kobj.Kinematic(true);
        }

    }
}

