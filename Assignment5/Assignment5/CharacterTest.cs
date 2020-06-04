using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment5
{
    [TestFixture]
    class CharacterTest
    {
        Character character;

        [SetUp]
        public void Setup()
        {
            character = new Character("Scott", RaceCatagory.Elf, 200);
        }

        [TestCase(1,199)]
        [TestCase(10,190)]
        public void TestDamageCharacter(int damage, int expected)
        {
            character.TakeDamage(damage);
            int actual = character.HealthPoints;

            Assert.AreEqual(actual, expected);
        }

        [TestCase(1, 201)]
        [TestCase(10, 210)]
        public void TestRestoreHealth(int heal, int expected)
        {
            character.RestoreHealth(heal);
            int actual = character.HealthPoints;

            Assert.AreEqual(actual, expected);
        }
    }
}
