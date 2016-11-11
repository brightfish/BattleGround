using BattleGround.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGround.Model
{

    public class Unicorn : IBattleable
    {
        public CharacterTypes Type { get; set; }

        public Unicorn()
        {
            Type = CharacterTypes.Unicorn;
        }

        /// <summary>
        /// IBattleable implemented using if and is statements
        /// </summary>
        /// <param name="other">The opponent</param>
        /// <returns>True if the character won the battle and false if the battle was lost.</returns>
        public bool Battle(IBattleable other)
        {
            if (other is Wearwolf)
            {
                return true;
            }
            else if (other is TRex)
            {
                return true;
            }
            else if (other is Dragon)
            {
                return false;
            }
            else if (other is Unicorn)
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
