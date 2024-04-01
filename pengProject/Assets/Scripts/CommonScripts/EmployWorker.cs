using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KMS.Worker.Factory;

namespace KMS.Worker
{
    public class EmployWorker : MonoBehaviour
    {

        Vector3 selectedPos = Vector3.zero;
        WorkerFactory workerFactory;

        // Start is called before the first frame update
        void Start()
        {
            workerFactory = new PenguinFactory();
        }

        public void ChangeFactory(WorkerFactory factory)
        {
            workerFactory = factory;
        }

        //focused change vector pos
        public void EmployOrder()
        {
            workerFactory.Employ(selectedPos);
        }
    }
}

