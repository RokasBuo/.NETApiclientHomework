using ApiClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogAPI
{
    public class SubBreedCache
    {
        private Dictionary<string, SubBreedsResponse> known_subbreeds = new Dictionary<string, SubBreedsResponse>();

        public SubBreedsResponse GetSubBreeds(string breedname)
        {
            if (known_subbreeds.ContainsKey(breedname))
            {
                return known_subbreeds[breedname];
            }

            SubBreedsResponse sub = (SubBreedsResponse)ApiHelper.GetSubBreeds(breedname);
            addSubBreeds(breedname,sub);
            return (SubBreedsResponse)sub;
        }
        public Boolean addSubBreeds(string breedname, SubBreedsResponse subbreeds)
        {
            if (known_subbreeds.ContainsKey(breedname))
            {
                return false;
            }
            known_subbreeds[breedname] = (SubBreedsResponse)subbreeds;
            return true;
        }
    }
}
