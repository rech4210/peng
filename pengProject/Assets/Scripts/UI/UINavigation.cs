using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UINavigation : MonoBehaviour
{
    MasterContext masterContext;
    MasterContext masterContext2;
    private void Start()
    {
        masterContext = new UIMainContext();
        //masterContext.ContextName = "new name";
        //masterContext.ContextDescription = "new description";
    }

}
