using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditorInternal;
#endif

using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

//implementation override
public partial class Implementation
{
    [SerializeField]
    [TextArea]
    string tip = "Fields Can Be Added & Will Apear In The MonoBehaviour";

    protected override void Method()
    {
        Debug.Log("Override Method");

        tip.Equals("Dont Give Me A Warning Unity");
    }
}