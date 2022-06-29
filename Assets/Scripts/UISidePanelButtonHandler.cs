using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISidePanelButtonHandler : MonoBehaviour
{
    [SerializeField]
    private UIManager.UIState buttonAction;

    [SerializeField]
    private UIManager uiManager;

    public void toggleAction()
    {
        uiManager.toggleUI (buttonAction);
    }
}
