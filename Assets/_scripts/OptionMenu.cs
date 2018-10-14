using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenu : MonoBehaviour {

    public GameObject creditmenu, mainmenu;
    
    public void Back()
    {
        mainmenu.SetActive(true);
        this.gameObject.SetActive(false);
    }

}
