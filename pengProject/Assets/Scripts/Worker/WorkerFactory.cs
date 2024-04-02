using KMS.Class;
using System;
using UnityEngine;


namespace KMS.Worker.Factory
{
    public abstract class WorkerFactory
    {
        protected WorkerSpec workerStandard;
        //[SerializeField] protected Workers workerGameObject;
        public abstract void Employ(Workers workerGameObject, Vector3 pos);
        public abstract void ManageEmploy();
        public abstract void SetEmployeeSpec();

    }
}
