using BattleGround.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGround.Model
{    
    public class Wearwolf : IBattleable
    {
        public CharacterTypes Type { get; set; }

        public Wearwolf()
        {
            Type = CharacterTypes.Wearwolf;
        }

        /// <summary>
        /// Implemented using if statements checking the Type property of the IBattleable interface
        /// </summary>
        /// <param name="other">The enemy</param>
        /// <returns>True if the character won the battle and false if the battle was lost.</returns>
        public bool Battle(IBattleable other)
        {
            if (other.Type == CharacterTypes.Dragon)
            {
                return true;
            }
            else if (other.Type == CharacterTypes.TRex)
            {
                return false;
            }
            else if (other.Type == CharacterTypes.Unicorn)
            {
                return false;
            }
            else if (other.Type == CharacterTypes.Wearwolf)
            {
                return false;
            }
            else
            {
                //When adding more class types this is useful in detecting areas of the code which require implementation
                throw new NotImplementedException();
            }
        }
    }
}

