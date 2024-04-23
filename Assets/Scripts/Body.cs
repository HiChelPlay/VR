using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    [SerializeField] private Hands hands1;
    [SerializeField] private Hands hands2;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    private void Update()
    {
        if ((Input.GetMouseButton(0) || Input.GetMouseButton(1)) && hands1.isclimb && hands2.isclimb)
            this.GetComponent<Rigidbody>().isKinematic = false;
        if (!Input.GetMouseButton(0) && !Input.GetMouseButton(1))
        {
            this.GetComponent<Rigidbody>().isKinematic = true;
            //float posx = transform.position.x;
            //float posz = transform.position.z;
            //float posy = transform.position.y - 1f;
            //transform.position = new Vector3(posx, posy, posz);
        }
    }
}
