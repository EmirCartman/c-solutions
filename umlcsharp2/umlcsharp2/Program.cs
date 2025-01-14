using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlcsharp2
{
    
    public interface IIdentifiable
    {
        Guid Id { get; }
    }

   
    public interface IExperienced
    {
        void GainExperience();
    }

    
    public class Pet : IIdentifiable
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Age { get; set; }
        public Owner Owner { get; set; }
        public Animal Type { get; set; }
        public PetInformation PetInfo { get; set; }

        public void Feed()
        {
            
        }

        public bool IsHerbivore()
        {
            return Type != null && !Type.Carnivore;
        }
    }

    
    public class Owner : IExperienced
    {
        public string Name { get; set; }

        public void GainExperience()
        {
            
        }
    }

   
    public class Animal
    {
        public string Type { get; set; }
        public string Breed { get; set; }
        public bool Carnivore { get; set; }
    }

    
    public class PetInformation
    {
        public List<string> Traits { get; set; } = new List<string>();
        public List<Vaccine> Vaccines { get; set; } = new List<Vaccine>();
    }

    
    public class Vaccine
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }

}
