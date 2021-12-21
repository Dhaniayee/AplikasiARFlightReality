using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject PanelInfo;
    public GameObject PanelInfo1;
    public GameObject PanelInfo2;
    public GameObject PanelInfo3;
    public GameObject PanelInfo4;
    public GameObject PanelInfo5;
    public GameObject PanelInfo6;
    public GameObject PanelInfo7;
    public GameObject PanelInfo8;
    public GameObject PanelInfo9;
    public GameObject kokpit;
    public GameObject kabin;
    public GameObject sayap;
    public GameObject gear;
    public bool show = false;
    public bool show1 = false;
    public bool show2 = false;
    public bool show3 = false;
    public bool show4 = false;
    public bool show5 = false;
    public bool show6 = false;
    public bool show7 = false;
    public bool show8 = false;
    public bool show9 = false;
     
    public void showHideInfo()
    {
        if(!show){
            PanelInfo.SetActive(true);
            show = true;
        } 
        else 
        {
            PanelInfo.SetActive(false);
            show = false;
        }
    }
    public void showHideInfo1()
    {
        if(!show1){
            PanelInfo1.SetActive(true);
            show1 = true;
        } 
        else 
        {
            PanelInfo1.SetActive(false);
            show1 = false;
        }
    }
    public void showHideInfo2()
    {
        if(!show2){
            PanelInfo2.SetActive(true);
            show2 = true;
        } 
        else 
        {
            PanelInfo2.SetActive(false);
            show2 = false;
        }
    }
    public void showHideInfo3()
    {
        if(!show3){
            PanelInfo3.SetActive(true);
            show3 = true;
        } 
        else 
        {
            PanelInfo3.SetActive(false);
            show3 = false;
        }
    }

    public void showHideInfo4()
    {
        if(!show4){
            PanelInfo4.SetActive(true);
            show4 = true;
        } 
        else 
        {
            PanelInfo4.SetActive(false);
            show4 = false;
        }
    }

    public void showHideInfo5()
    {
        if(!show5){
            PanelInfo5.SetActive(true);
            show5 = true;
        } 
        else 
        {
            PanelInfo5.SetActive(false);
            show5 = false;
        }
    }

    public void showHideInfo6()
    {
        if(!show6){
            PanelInfo6.SetActive(true);
            kokpit.SetActive(false);
            show6 = true;
        } 
        else 
        {
            PanelInfo6.SetActive(false);
            kokpit.SetActive(true);
            show6 = false;
        }
    }
    public void showHideInfo7()
    {
        if(!show7){
            PanelInfo7.SetActive(true);
            kabin.SetActive(false);
            show7 = true;
        } 
        else 
        {
            PanelInfo7.SetActive(false);
            kabin.SetActive(true);
            show7 = false;
        }
    }

    public void showHideInfo8()
    {
        if(!show8){
            PanelInfo8.SetActive(true);
            sayap.SetActive(false);
            show8 = true;
        } 
        else 
        {
            PanelInfo8.SetActive(false);
            sayap.SetActive(true);
            show8 = false;
        }
    }

    public void showHideInfo9()
    {
        if(!show9){
            PanelInfo9.SetActive(true);
            gear.SetActive(false);
            show9 = true;
        } 
        else 
        {
            PanelInfo9.SetActive(false);
            gear.SetActive(true);
            show9 = false;
        }
    }

    public void buttonBack()
    {
        Application.LoadLevel("StartMenu");
    }
}

