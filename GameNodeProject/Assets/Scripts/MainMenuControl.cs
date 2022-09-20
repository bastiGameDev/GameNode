using System;
using UnityEngine;
using DG.Tweening;


public class MainMenuControl : MonoBehaviour
{
    [SerializeField] private RectTransform loginField;
    [SerializeField] private RectTransform passwordField;

    private void Start()
    {
        loginField.DOMoveX(0f, 1.3f).SetEase(Ease.InOutElastic);
        passwordField.DOMoveX(0f, 1.3f).SetEase(Ease.InOutElastic);
    }
}
