using KMS.Class;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerModel : Model<WorkerModel>
{
    
    private WorkerSpec penguinWorker;
    private WorkerSpec bearWorker;

    public void ada()
    {
    }
    public WorkerSpec PenguinWorker { get { return penguinWorker; } set { penguinWorker = value; } }
    public WorkerSpec BearWorker { get { return penguinWorker; } set { penguinWorker = value; } }

}
