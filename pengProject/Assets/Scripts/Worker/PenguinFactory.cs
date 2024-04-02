using KMS.Class;
using System.Collections.Generic;
using System.Runtime.Versioning;
using UnityEngine;

namespace KMS.Worker.Factory
{
    public class PenguinFactory : WorkerFactory
    {
        List<Penguin> penguinList;
        //public WorkerSpecSO workerSpecSO;

        public override void Employ(Workers workerGameObject, Vector3 pos)
        {
            var worker = Object.Instantiate(workerGameObject, pos, Quaternion.identity) as Penguin;
            worker.gameObject.GetComponent<Penguin>().SetWorkerSpec(workerStandard);
            penguinList.Add(worker); // -> 이부분 액션 처리할까?
        }

        public override void ManageEmploy()
        {
            throw new System.NotImplementedException();
        }

        public override void SetEmployeeSpec(/*WorkerSpecSO specSO*/)
        {
            //workerStandard = specSO;
            workerStandard = new WorkerSpec(0,0,new Struct.Resource(0,0,0), new Struct.Resource(0, 0, 0));
        }
    }
}
