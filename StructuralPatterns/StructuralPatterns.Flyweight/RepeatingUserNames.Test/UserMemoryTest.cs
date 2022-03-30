using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.dotMemoryUnit;
using NUnit.Framework;
using RepeatingUserNames.Classes;

namespace RepeatingUserNames.Test
{
    [TestFixture]
    public class UserMemoryTest
    {
        [Test]
        public void UserTest() // 7463858 bytes
        {
            var firstNames = Enumerable.Range(0, 100).Select(_ => RandomString());
            var lastNames = Enumerable.Range(0, 100).Select(_ => RandomString());

            List<User> users = new List<User>();

            foreach (var firstName in firstNames)
                foreach (var lastName in lastNames)
                    users.Add(new User($"{firstName} {lastName}"));

            ForceGC();

            dotMemory.Check(memory =>
            {
                Console.WriteLine(memory.SizeInBytes);
            });
        }
        
        [Test]
        public void UserWithCacheTest() // 7143728 bytes
        {
            var firstNames = Enumerable.Range(0, 100).Select(_ => RandomString());
            var lastNames = Enumerable.Range(0, 100).Select(_ => RandomString());

            List<UserWithCache> users = new List<UserWithCache>();

            foreach (var firstName in firstNames)
                foreach (var lastName in lastNames)
                    users.Add(new UserWithCache($"{firstName} {lastName}"));

            ForceGC();

            dotMemory.Check(memory =>
            {
                Console.WriteLine(memory.SizeInBytes);
            });
        }

        private void ForceGC()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private string RandomString()
        {
            Random rand = new Random();

            return new string(
                Enumerable.Range(0, 10)
                    .Select(i => (char)('a' + rand.Next(26)))
                    .ToArray());
        }
    }
}