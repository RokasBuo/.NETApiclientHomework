using ApiClient;
using DogAPI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{

    public interface ISubBreedsProvider
    {
        SubBreedsResponse GetSubBreeds();
    }

    class SubBreedsTestProvider: ISubBreedsProvider
    {
        public SubBreedsResponse subbreeds;
        public SubBreedsResponse GetSubBreeds()
        {
            return subbreeds;

        }
    }

    public class DogModel
    {
        public string Breed { get; set; }
    }


    [TestClass]
    public class UnitTest1
    {
        SubBreedCache cache = new SubBreedCache();

        [TestMethod]
        public void TestMethod1()
        {
            DogModel dog = new DogModel{
                Breed = "Australian"
            };

            SubBreedsResponse subs = cache.GetSubBreeds(dog.Breed);


        }
    }
}
