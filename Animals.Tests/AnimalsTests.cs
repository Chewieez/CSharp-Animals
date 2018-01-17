using System;
using Xunit;

namespace Animals.Tests
{
    public class AnimalsShould
    {
        public Animal cow;
        public Dog labrador;

        public AnimalsShould()
        {
            cow = new Animal();
            labrador = new Dog();
        }
        
        [Fact]
        public void NameAnimal()
        {
            cow.Name = "Mooer";
            Assert.Equal("Mooer", cow.Name);
        }


        [Fact]
        public void HoldSpecies()
        {
            cow.Species = "bovine";
            Assert.Equal("bovine", cow.Species);
        }

        [Fact]
        public void CowWalk()
        {
            cow.Speed = 4;
            
            cow.Walk();

            Assert.Equal(4, cow.Walk());
        }


        [Fact]
        public void DogWalk()
        {
            labrador.Speed = 6;

            labrador.Walk();

            Assert.Equal(6, labrador.Walk());
        }

        [Fact]
        public void IsInstanceOf()
        {

           Assert.Equal(typeof(Animal), cow.GetType());

        //  Another method.  Better?
        //  Assert.IsType(expectedDog, new Dog());
           Assert.Equal(typeof(Dog), labrador.GetType());

        }


    }
}
