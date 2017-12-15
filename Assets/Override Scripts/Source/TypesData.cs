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

public class BaseTypesData
{
    //declare an empty class that derived from the class we want to derive the implementation from
    public class ImplementationBase : MonoBehaviour
    {

    }
}

public partial class TypesData : BaseTypesData
{

}