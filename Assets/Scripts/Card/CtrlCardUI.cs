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



}// void ������Ʈ �߰��Ϸ��� ���� �߰�ȣ ����� ��.
    /*void Update()
    {
        if (CardCrtBtn)
        {
            Debug.Log("���콺 �Է� �޾ҽ�");
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
