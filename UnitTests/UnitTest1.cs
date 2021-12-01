using ApiClient;
using DogAPI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTests
{

    [TestClass]
    public class UnitTest1
    {
        SubBreedCache cache = new SubBreedCache();

        [TestMethod]
        public void TestMethod1()
        {

            List<string> subBreedName = new List<string> { "shepherd" };

            SubBreedsResponse sub = new SubBreedsResponse
            {
                Message = subBreedName,
            };

            string dog = "australian";

            cache.addSubBreeds(dog, sub);

            Assert.AreEqual(1, cache.known_subbreeds.Count);

            SubBreedsResponse sub2 = cache.GetSubBreeds(dog);
            Assert.AreEqual(1, cache.known_subbreeds.Count);

            Assert.AreEqual(sub, cache.GetSubBreeds(dog));
        }
    }
}