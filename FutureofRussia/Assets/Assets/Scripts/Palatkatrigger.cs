using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Palatkatrigger : MonoBehaviour
{
    [SerializeField] GameObject PanelDialog;
    public Text dialog;
    public string[] message;
    public bool DialogStart = false;

    void Start()
    {
        message[0] = "Hello";
        message[1] = "You're a fucking stupid bitch!";
        PanelDialog.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            PanelDialog.SetActive(true);
            dialog.text = message[0];
            DialogStart = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PanelDialog.SetActive(false);
            DialogStart = false;
        }
    }
    private void Update()
    {
        if (DialogStart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                dialog.text = message[1];
            }
        }
    }
}
