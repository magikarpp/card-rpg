using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SidePanelViewButton : MonoBehaviour
{
    [SerializeField]
    private View view;

    [SerializeField]
    private Button _button;

    public void Start()
    {
        _button.onClick.AddListener(() => ViewManager.Show(view));
    }
}
