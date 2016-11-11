using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleGround.Model;
using BattleGround.Model.Interfaces;

namespace BattleGround.Tests
{
    /// <summary>
    /// Unit tests for the classes inheriting IBattleable.  Classes are implemented in various ways to show how interfaces can be leveraged to switch out implementation.  
    /// </summary>
    [TestClass]
    public class BattleableUnitTests
    {
        [TestMethod]
        public void UnicornsShouldBeUnicorns()
        {
            IBattleable unicorn = new Unicorn();

            Assert.AreEqual(unicorn.Type, CharacterTypes.Unicorn);
            Assert.IsTrue(unicorn is Unicorn);
        }

        [TestMethod]
        public void WearwolvesShouldBeWearwolves()
        {
            IBattleable wearwolf = new Wearwolf();

            Assert.AreEqual(wearwolf.Type, CharacterTypes.Wearwolf);
            Assert.IsTrue(wearwolf is Wearwolf);
        }

        [TestMethod]
        public void DragonsShouldBeDragons()
        {
            IBattleable dragon = new Dragon();

            Assert.AreEqual(dragon.Type, CharacterTypes.Dragon);
            Assert.IsTrue(dragon is Dragon);
        }

        [TestMethod]
        public void TRexsShouldBeTRexs()
        {
            IBattleable trex = new TRex();

            Assert.AreEqual(trex.Type, CharacterTypes.TRex);
            Assert.IsTrue(trex is TRex);
        }

        [TestMethod]
        public void UnicornShouldBeatWearwolf()
        {
            IBattleable unicorn = new Unicorn();
            IBattleable wearwolf = new Wearwolf();

            bool result = unicorn.Battle(wearwolf);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UnicornShouldBeatTRex()
        {
            IBattleable unicorn = new Unicorn();
            IBattleable trex = new TRex();

            bool result = unicorn.Battle(trex);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UnicornShouldNotBeatDragon()
        {
            IBattleable unicorn = new Unicorn();
            IBattleable dragon = new Dragon();

            bool result = unicorn.Battle(dragon);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UnicornShouldNotBeatUnicorn()
        {
            IBattleable unicornOne = new Unicorn();
            IBattleable unicornTwo = new Unicorn();

            bool result = unicornOne.Battle(unicornTwo);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void WearwolfShouldBeatDragon()
        {
            IBattleable wearwolf = new Wearwolf();
            IBattleable dragon = new Dragon();

            bool result = wearwolf.Battle(dragon);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void WearwolfShouldNotBeatTRex()
        {
            IBattleable wearwolf = new Wearwolf();
            IBattleable trex = new TRex();

            bool result = wearwolf.Battle(trex);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void WearwolfShouldNotBeatUnicorn()
        {
            IBattleable wearwolf = new Wearwolf();
            IBattleable unicorn = new Unicorn();

            bool result = wearwolf.Battle(unicorn);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void WearwolfShouldNotBeatWearwolf()
        {
            IBattleable wearwolfOne = new Wearwolf();
            IBattleable wearwolfTwo = new Wearwolf();

            bool result = wearwolfOne.Battle(wearwolfTwo);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DragonShouldBeatUnicorn()
        {
            IBattleable dragon = new Dragon();
            IBattleable unicorn = new Unicorn();

            bool result = dragon.Battle(unicorn);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DragonShouldBeatTRex()
        {
            IBattleable dragon = new Dragon();
            IBattleable trex = new TRex();

            bool result = dragon.Battle(trex);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DragonShouldNotBeatWearwolf()
        {
            IBattleable dragon = new Dragon();
            IBattleable wearwolf = new Wearwolf();

            bool result = dragon.Battle(wearwolf);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DragonShouldNotBeatDragon()
        {
            IBattleable dragonOne = new Dragon();
            IBattleable dragonTwo = new Dragon();

            bool result = dragonOne.Battle(dragonTwo);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TRexShouldBeatWearwolf()
        {
            IBattleable trex = new TRex();
            IBattleable wearwolf = new Wearwolf();

            bool result = trex.Battle(wearwolf);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TRexShouldNotBeatUnicorn()
        {
            IBattleable trex = new TRex();
            IBattleable unicorn = new Unicorn();

            bool result = trex.Battle(unicorn);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TRexShouldNotBeatDragon()
        {
            IBattleable trex = new TRex();
            IBattleable dragon = new Dragon();

            bool result = trex.Battle(dragon);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TRexShouldNotBeatTRex()
        {
            IBattleable trexOne = new TRex();
            IBattleable trexTwo = new TRex();

            bool result = trexOne.Battle(trexTwo);

            Assert.IsFalse(result);
        }
    }
}
