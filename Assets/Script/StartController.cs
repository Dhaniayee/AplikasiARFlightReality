using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartController : MonoBehaviour
{
    public GameObject PanelMenuHome;

    // Start is called before the first frame update
    void Start()
    {
        PanelMenuHome.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonStart()
    {
        Application.LoadLevel("ScanMarker");
    }

    public void ButtonExit()
    {
        Application.Quit();
    }
}
