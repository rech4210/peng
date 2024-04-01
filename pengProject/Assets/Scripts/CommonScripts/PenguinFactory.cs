using System.Collections.Generic;
using UnityEngine;

namespace KMS.Worker.Factory
{
    public class PenguinFactory : WorkerFactory
    {
        List<Penguin> penguinList;

        public override void Employ(Vector3 pos)
        {
            var worker = Object.Instantiate(workerGameObject, pos, Quaternion.identity) as Penguin;
            penguinList.Add(worker); // -> 이부분 액션 처리할까?
        }

        public override void ManageEmploy()
        {
            throw new System.NotImplementedException();
        }

        public override void SetEmployeeSpec()
        {
            throw new System.NotImplementedException();
        }
    }

}
