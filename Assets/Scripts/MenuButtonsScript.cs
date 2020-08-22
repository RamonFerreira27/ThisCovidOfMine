using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtonsScript : MonoBehaviour
{
    public Button ActionsButton;
    public GameObject ActionsMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateMenu()
    {
        ActionsMenu.GetComponent<GameObject>();
        if (ActionsMenu.activeSelf)
            ActionsMenu.SetActive(false);
        else
            ActionsMenu.SetActive(true);
    }
}
