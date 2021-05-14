using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class LoginRegister : MonoBehaviour
{
    [SerializeField] Button mButton;
    [SerializeField] Toggle mToggle;
    [SerializeField] Scrollbar mScrollbar;
    [SerializeField] ScrollRect mScrollRect;
    [SerializeField] Slider mSlider;
    [SerializeField] InputField mInputField;

    private void Start()
    {
        mButton.OnClickAsObservable().Subscribe(_ => Debug.LogError("mButton Click:" + _));
        mToggle.OnValueChangedAsObservable().Subscribe(isOn => Debug.LogError("Toggle value change:" + isOn));
    }
}
