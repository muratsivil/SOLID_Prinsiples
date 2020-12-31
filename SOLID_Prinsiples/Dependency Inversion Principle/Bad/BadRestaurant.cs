using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Prinsiples.Dependency_Inversion_Principle.Bad
{
    public class BadRestaurant
    {
        BadFish salmon = new BadFish();
        BadPoultry duck = new BadPoultry();

        public string GenerateInstruction()
        {
            return salmon.GetFishInstruction() + " " + duck.GetPoultryCookingInstructions();
        }
    }
}
