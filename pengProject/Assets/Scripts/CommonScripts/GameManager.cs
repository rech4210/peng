using UnityEngine;
using KMS.Struct;

namespace KMS.Singleton
{
    public class GameManager : MonoBehaviour
    {
        Resource resource;

        private float penguinBingneral = 0;
        private float penguinEnergy = 0;



        public static GameManager instance;
        public int bingneral { get { return resource.bingneral; } set { resource.bingneral += value; } }
        public int energy { get { return resource.energy; } set { resource.energy += value; } }
        public int emperorCoin { get { return resource.emperorCoin; } set { resource.emperorCoin += value; } }

        void Start()
        {
            instance = this;
            resource = new Resource(0, 0, 0);
        }


        public Resource GetPenguinResource()
        {
            return resource;
        }
    }
}
