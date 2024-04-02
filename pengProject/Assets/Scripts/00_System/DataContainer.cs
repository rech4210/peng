using KMS.Struct;
using System;

namespace KMS.Enum
{
    [System.Serializable]
    public enum PenguinState
    {
        Pacing,
        Working,
        DozeOff,
        Resting,
        Eating
    }

}

namespace KMS.Class
{
    [System.Serializable]
    public class WorkerSpec
    {
        public float miningDuration;
        public float miningPoint;
        public Resource spawnCost;
        public Resource upgradeCost;
        public WorkerSpec(float duration, float point, Resource spwnCost, Resource upCost)
        {
            miningDuration = duration;
            miningPoint = point;
            spawnCost = spwnCost;
            upgradeCost = upCost;
        }
    }
}

namespace KMS.Struct
{
    [Serializable]
    public struct Resource
    {
        public int bingneral;
        public int energy;
        public int emperorCoin;

        public Resource(int bingneral, int energy, int emperorCoin)
        {
            this.bingneral = bingneral;
            this.energy = energy;
            this.emperorCoin = emperorCoin;
        }
    }
}

