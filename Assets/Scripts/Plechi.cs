using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plechi : MonoBehaviour
{
    [SerializeField] private Hands hands;
    private float posx, posy, posz;

    private void Update()
    {
        //if (Mathf.Abs(posx) > Mathf.Abs(hands.posx)+1)
        //    transform.position = new Vector3(hands.posx, posy, posz);
        //if (Mathf.Abs(posy) > Mathf.Abs(hands.posy)+1)
        //    transform.position = new Vector3(posx, hands.posy, posz);
        //if (posz > hands.posz+1)
        //    transform.position = new Vector3(posx, posy, hands.posz);
        //transform.position = new Vector3(hands.posx, hands.posy, hands.posz);
    }
}
