using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.ScriptableObject
{
    [Serializable]
    public class PlayerData
    {
        public string PlayerName;
        public int Balance;
        public List<string> Products;
    }

    
}
