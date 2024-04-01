using UnityEngine;
using KMS.Struct;
using Sirenix.OdinInspector;

namespace KMS.Singleton
{
    public class GameManager : Manager<GameManager>
    {
        [BoxGroup("∆Î±œ ¿Á»≠")]
        [SerializeField] public Resource resource;


        public static GameManager instance;
        public int Bingneral { get { return resource.bingneral; } set { resource.bingneral += value; } }
        public int Energy { get { return resource.energy; } set { resource.energy += value; } }
        public int EmperorCoin { get { return resource.emperorCoin; } set { resource.emperorCoin += value; } }

        public override void Init()
        {
            resource = new Resource(0, 0, 0);
        }


        public Resource GetPenguinResource()
        {
            return resource;
        }
        public void SetPenguinResource(int bing, int energy)
        {
            Bingneral += bing;
            Energy += energy;
        }
    }
}
