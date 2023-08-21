using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SampleSceneControl : MonoBehaviour
{
    private void Start()
    {
        UIDocument uiDocument = FindObjectOfType<UIDocument>();
        VisualElement scrollView = uiDocument.rootVisualElement.Q("demoScrollView");
        Button showButton = uiDocument.rootVisualElement.Q<Button>("showButton");
        Button hideButton = uiDocument.rootVisualElement.Q<Button>("hideButton");

        // After hide and show, the scroll position is lost.
        // This also happens with a ListView component.
        hideButton.RegisterCallback<ClickEvent>(_ => scrollView.style.display = DisplayStyle.None);
        showButton.RegisterCallback<ClickEvent>(_ => scrollView.style.display = DisplayStyle.Flex);
    }
}
