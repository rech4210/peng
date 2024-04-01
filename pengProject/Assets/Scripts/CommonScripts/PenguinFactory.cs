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
            penguinList.Add(worker); // -> �̺κ� �׼� ó���ұ�?
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
