using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View_models : MonoBehaviour
{
    public GameObject menu;
    public GameObject survey;

    public void Toggle_Changed(bool newValue) {
        menu.SetActive(newValue);
    }

}
