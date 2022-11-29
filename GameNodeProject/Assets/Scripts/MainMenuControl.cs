using System;
using UnityEngine;
using DG.Tweening;


public class MainMenuControl : MonoBehaviour
{
    [SerializeField] private RectTransform loginField;
    [SerializeField] private RectTransform passwordField;
    [SerializeField] private GameObject panelAuthorization;
    [SerializeField] private GameObject panelMain;

    private void Start()
    {
        //loginField.DOMoveX(0f, 1.3f).SetEase(Ease.InOutElastic);
        //passwordField.DOMoveX(0f, 1.3f).SetEase(Ease.InOutElastic);
    }

    public async void Click()
    {
        await panelAuthorization.transform.DOMoveX(-80, 1f).SetEase(Ease.InOutQuint).AsyncWaitForCompletion();
        panelAuthorization.SetActive(false);
    }

    public async void ButtonMyGamesClick()
    {
        await panelMain.transform.DOMoveX(-70f, 1f).SetEase(Ease.InOutQuint).AsyncWaitForCompletion();
        panelMain.SetActive(false);
    }

    public async void ButtonMyAccountClick()
    {
        await panelMain.transform.DOMoveX(-70f, 1f).SetEase(Ease.InOutQuint).AsyncWaitForCompletion();
        panelMain.SetActive(false);
    }

    public async void ButtonMoreGamesClick()
    { 
        await panelMain.transform.DOMoveX(-70f, 1f).SetEase(Ease.InOutQuint).AsyncWaitForCompletion();
        panelMain.SetActive(false);
    }
}
