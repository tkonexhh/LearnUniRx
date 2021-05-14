using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class ReactivePropertyExample : MonoBehaviour
{

    public IntReactiveProperty Age = new IntReactiveProperty(0);

    void Start()
    {
        Age.Subscribe(age =>
        {
            Debug.LogError("Age change:" + age);
        });

        Age.Value = 10;
    }


}
