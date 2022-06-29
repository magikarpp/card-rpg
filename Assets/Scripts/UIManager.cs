using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public enum UIState
    {
        Main,
        Character,
        Inventory,
        Deck,
        Party,
        Map,
        Quest,
        Settings
    }

    public GameObject inventoryMenu;

    public UIState uiState;

    void Start()
    {
        uiState = UIState.Main;
        inventoryMenu.gameObject.SetActive(false);
    }

    void Update()
    {
        UIControl();
    }

    private void UIControl()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            toggleUI(UIState.Inventory);
        }
    }

    public void toggleUI(UIState incomingState)
    {
        if (incomingState == UIState.Inventory)
        {
            toggleInventory();
        }
    }

    private void toggleInventory()
    {
        if (uiState != UIState.Inventory)
        {
            uiState = UIState.Inventory;
            inventoryMenu.gameObject.SetActive(true);
        }
        else
        {
            uiState = UIState.Main;
            inventoryMenu.gameObject.SetActive(false);
        }
    }
}
