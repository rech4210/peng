using UnityEngine;


namespace KMS.Worker.Factory
{
    public abstract class WorkerFactory
    {

        [SerializeField] protected Workers workerGameObject;
        public abstract void Employ(Vector3 pos);

        public abstract void ManageEmploy();
        public abstract void SetEmployeeSpec();

    }
}
