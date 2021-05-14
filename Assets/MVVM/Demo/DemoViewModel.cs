using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class DemoViewModel
{
    public ReactiveProperty<int> Age { get; private set; }
    public ReactiveProperty<int> Num { get; private set; }
    public ReactiveProperty<string> Str { get; private set; }


    public DemoViewModel()
    {
        Age = new ReactiveProperty<int>(DemoModel.Age);
        Num = new ReactiveProperty<int>(DemoModel.Num);
        Str = new ReactiveProperty<string>(DemoModel.Str);

        // Str.ToReactiveProperty
        Str.Subscribe(newStr =>
        {
            Debug.LogError("VM:" + newStr);
            DemoModel.Str = newStr;
        });
    }
}
