using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtonsScript : MonoBehaviour
{
    public GameObject ActionsMenu;

    public void ActivateMenu()
    {
        ActionsMenu.GetComponent<GameObject>();
        if (ActionsMenu.activeSelf)
            ActionsMenu.SetActive(false);
        else
            ActionsMenu.SetActive(true);
    }

    
}
