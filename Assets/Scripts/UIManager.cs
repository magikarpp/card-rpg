using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UIMainPanel
{
    Inventory
}

public class UIManager : MonoBehaviour
{
    public UIMainPanel mainPanelCurrentState;

    public UIMainPanel mainPanelPreviousState;

    public GameObject inventoryMenu;

    void Start()
    {
        inventoryMenu.gameObject.SetActive(false);
    }

    void Update()
    {
        InventoryControl();
    }

    private void InventoryControl()
    {
        // Inputs for opening Inventory
        if (true)
        {
            if (GameManager.instance.isPaused)
            {
            }
        }
    }
}
