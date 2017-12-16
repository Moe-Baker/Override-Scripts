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

//abstract class the acts as the functionality implementation
public abstract class BaseImplementation : DataTypes.ImplementationBase
{
    void Start()
    {
        Method();
    }

    protected virtual void Method()
    {
        Debug.Log("Implementation Method");
    }
}

//empty partial class that derives the implementation, should be used as if implementation
public partial class Implementation : BaseImplementation
{

}