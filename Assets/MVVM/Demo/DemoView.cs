using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class DemoView : AbstactView
{
    [SerializeField] private Text m_TxtValue;
    [SerializeField] private InputField m_InputField;

    [SerializeField] private string str;

    private DemoViewModel m_ViewModel;
    // Start is called before the first frame update
    void Start()
    {
        m_ViewModel = new DemoViewModel();
        m_ViewModel.Str.Subscribe(str =>
        {
            m_TxtValue.text = str;
        });
        m_InputField.onValueChanged.AddListener(str =>
        {
            Debug.LogError("onValueChanged");
            m_ViewModel.Str.Value = str;
        });
        // m_InputField.OnValueChangedAsObservable().Subscribe(str =>
        // {
        //     m_ViewModel.Str.Value = str;
        // });
        // 
    }

    // Update is called once per frame
    void Update()
    {
        str = DemoModel.Str;
    }
}
