using System;

namespace KMS.Enum
{
    public enum PenguinState
    {
        Pacing,
        Working,
        DozeOff,
        Resting,
        Eating
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

