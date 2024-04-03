using KMS.Class;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerViewModel : MasterViewModel
{
    WorkerModel workerModel;

    private WorkerSpec penguinSpecView;
    private WorkerSpec bearWorkerSpecView;

    public WorkerSpec PenguinSpecView { get { return penguinSpecView; } private set {}}
    public WorkerSpec BearWorkerSpecView { get { return bearWorkerSpecView; } private set {}}

    public override void FetchData()
    {
        base.FetchData();
    }
    public override void SetModelData()
    {
        base.SetModelData();
    }



    // Start is called before the first frame update
    void Start()
    {
        workerModel = new WorkerModel();
        var asd = workerModel.Data.BearWorker;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
