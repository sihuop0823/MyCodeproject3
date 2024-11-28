using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CtrlCardUI : MonoBehaviour
{
    public GameObject CtrlPanel;
    public Button CtrlCrtBtn;

    private void Start()
    {
        CtrlPanel.SetActive(false);
    }
    /*private bool state;

    void Start()
    {
        state = true;
    }*/



}// void 업데이트 추가하려면 여기 중괄호 지우면 됨.
    /*void Update()
    {
        if (CardCrtBtn)
        {
            Debug.Log("마우스 입력 받았슴");
            if (state == true)
            {
                CtrlPanel.SetActive(false);
                Debug.Log("disapper");
                state = false;
            }

            else
            {
                CtrlPanel.SetActive(true);
                Debug.Log("apper");
                state = true;
            }
        }
    }
}*/
