using KMS.Class;
using KMS.Worker;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Model<T> where T : class, new()
{
    public T Data { get; set;}
    
}
