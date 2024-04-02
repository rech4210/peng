using KMS.Class;
using UnityEngine;

namespace KMS.Worker
{
    public class Workers : MonoBehaviour
    {
        protected WorkerSpec workerSpec;

        public virtual void SetWorkerSpec(WorkerSpec workerSpec) 
        {
            this.workerSpec = workerSpec;
        }

        public virtual void ViewWorkerSpec()
        {
            //show worker spec as UI
        }

        //work
        //rest
        //eat
    }
}


