using UnityEngine;
using KMS.Worker.Factory;
using Unity.VisualScripting;

namespace KMS.Worker
{
    public class EmployWorker : MonoBehaviour
    {
        public static EmployWorker instance;

        //Vector3 selectedPos = Vector3.zero;
        WorkerFactory workerFactory;

        // Start is called before the first frame update
        void Start()
        {
            workerFactory = new PenguinFactory();
            instance = this;
        }


        public void Onclicked()
        {
            //ChangeFactory();
            //selectedPos = Vector3.zero;
        }
        public WorkerFactory ChangeFactory(WorkerFactory factory)
        {
            return workerFactory = factory;
        }

        //focused change vector pos
        public void EmployOrder(Workers workerTarget , Vector3 pos)
        {
            workerFactory.Employ(workerTarget, pos);
        }
    }
}

