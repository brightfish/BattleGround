using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleGround.Model.Interfaces;

namespace BattleGround.Model
{
    public class TRex : IBattleable
    {
        public CharacterTypes Type { get; set; }

        public TRex()
        {
            Type = CharacterTypes.TRex;
        }

        /// <summary>
        /// IBattleable implemented using switch case statement.
        /// </summary>
        /// <param name="other">The opponent</param>
        /// <returns>True if the character won the battle and false if the battle was lost.</returns>
        public bool Battle(IBattleable other)
        {
            switch (other.Type)
            {
                case CharacterTypes.TRex:
                    return false;
                case CharacterTypes.Dragon:
                    return false;
                case CharacterTypes.Unicorn:
                    return false;
                case CharacterTypes.Wearwolf:
                    return true;
                default:
                    //When adding more class types this is useful in detecting areas of the code which require implementation
                    throw new NotImplementedException();
            }
        }
    }
}
