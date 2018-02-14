using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueBoxHandler : MonoBehaviour {
    public GameObject panelInstance;

    public void Hide()
    {
        if (panelInstance)
        {
            panelInstance.SetActive(false);
        } else
        {
            Debug.LogError("panelInstance is not set! Can't deactivate non-existant panel! The variable should point to the panel which contains this button.");
        }
    }
}
