using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class KinematicObj : MonoBehaviour
{
    public bool iskinematic;
    [SerializeField]private ArticulationBody obj;
    [SerializeField]private Rigidbody obj2;

    private void Start()
    {
        obj2.isKinematic = true;
    }

    private void Update()
    {
        obj.immovable = iskinematic;
    }

    public void Kinematic(bool kin)
    {
        obj2.isKinematic = kin;
    }
}

