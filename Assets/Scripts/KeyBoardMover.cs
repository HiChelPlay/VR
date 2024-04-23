using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class KeyBoardMover : MonoBehaviour
{
    [SerializeField] private float speed;
    private float posy;
    private float posz;
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
            posy = this.transform.position.y + speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
            posz = this.transform.position.z - speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            posy = this.transform.position.y - speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            posz = this.transform.position.z + speed * Time.deltaTime;
        this.transform.position = new Vector3(this.transform.position.x, posy, posz);
    }
}
