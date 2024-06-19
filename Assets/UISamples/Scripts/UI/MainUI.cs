using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    // [SerializeField] SimplePopup Popup_SimplePopup;

    private void OnDisable()
    {
        UIManager.Instance.RegisterOnClickConfirmEvent(false, OnClickConfirmPopup);
    }

    public void OnClick_PopupSimpleMsg()
    {
        // Popup_SimplePopup.SetUI();
        UIManager.Instance.OpenSimplePopup("심플 팝업 출력 됨");
    }

    public void OnClick_ConfirmBtn()
    {
        UIManager.Instance.OpenConfirmBtn("캐릭터 버튼 클릭");
        UIManager.Instance.RegisterOnClickConfirmEvent(true, OnClickConfirmPopup);
    }

    public void OnClickConfirmPopup()
    {
        Debug.Log("...");
    }
}
