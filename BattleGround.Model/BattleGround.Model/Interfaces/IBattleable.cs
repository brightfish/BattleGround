using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGround.Model.Interfaces
{
    public interface IBattleable
    {
        //Added to create multiple ways of implementing the code within inherited classes to demonstrate the 
        //point that classes inheriting from interfaces do not have to implement the methods in the same manner.  
        CharacterTypes Type { get; set; }

        bool Battle(IBattleable other);
    }
}
