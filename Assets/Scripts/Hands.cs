using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hands : MonoBehaviour
{
    //[SerializeField] private MouseMover mmover;
    [SerializeField] private int mousebtn;
    [SerializeField] private GameObject parent;
    public float posx, posy, posz;
    public bool isclimb;


    [SerializeField] private Image panel;
    [SerializeField] private GameObject text;
    [SerializeField] private GameObject ExitBtn;
    [SerializeField] private GameObject PausePanel;
    [SerializeField] private GameObject PauseBtn;
    public bool isPause = true;


    private void Start()
    {
        panel.color = new Color(1f, 1f, 1f, 0f);
        text.SetActive(false);
        ExitBtn.SetActive(false);
    }

    private void Update()
    {
        if (!Input.GetMouseButton(mousebtn) && !Input.GetKey("space"))
        {
            posx = transform.position.x;
            posy = transform.position.y;
            posz = transform.position.z;
        }
        else if ((Input.GetMouseButton(mousebtn) || Input.GetKey("space")) && isclimb)
        {
            transform.position = new Vector3(posx, posy, posz);
        }
        //transform.position = mmover.curPosition;
        //if (parent != null)
        //    transform.SetParent(parent.transform);
    }

    private void OnTriggerStay(Collider other)
    {
        
        if (other.tag == "Climbing" || other.tag == "Finish")
        {
            Debug.Log("XD");
            isclimb = true;
        }
        if (other.tag == "Finish" && Input.GetMouseButton(mousebtn))
        {
            Time.timeScale = 0f;
            panel.color = new Color(1f, 1f, 1f, 0.5f);
            text.SetActive(true);
            ExitBtn.SetActive(true);
            isPause = false;
            Destroy(PauseBtn);
            Destroy(PausePanel);
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("!!!");
        isclimb = false;
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Finish" && Input.GetMouseButtonDown(mousebtn))
    //    {
    //        Time.timeScale = 0f;
    //        panel.color = new Color(1f, 1f, 1f, 0.5f);
    //        text.SetActive(true);
    //        ExitBtn.SetActive(true);
    //    }
    //}
}
