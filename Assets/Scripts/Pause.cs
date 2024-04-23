using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    private bool ispaused;
    [SerializeField] private Image image;
    [SerializeField] private GameObject text;
    [SerializeField] private GameObject ExitBtn;
    

    private void Start()
    {
        ispaused = false;
        image.color = new Color(1f, 1f, 1f, 0f);
        text.SetActive(false);
        ExitBtn.SetActive(false);
    }


    private void Update()
    {
        if (Input.GetKeyDown("escape") && !ispaused)
        {
            Time.timeScale = 0f;
            ispaused = true;
            image.color = new Color(1f, 1f, 1f, 0.5f);
            text.SetActive(true);
            ExitBtn.SetActive(true);
        }
        else if (Input.GetKeyDown("escape") && ispaused)
        {
            ispaused = false;
            Time.timeScale = 1f;
            image.color = new Color(1f, 1f, 1f, 0f);
            text.SetActive(false);
            ExitBtn.SetActive(false);
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
}
