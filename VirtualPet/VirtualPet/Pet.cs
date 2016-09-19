using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Pet
    {
        //**********************
        //fields
        //**********************
        private string petsName;
        private int petsHungerLevel;
        private int petsThirstLevel;
        private int petsWasteLevel; 
        private int petsBoredomLevel;
        private int petsLoveLevel;
        private int petsOverallHealthLevel;

        //**********************
        //Properties
        //**********************
        public int Hunger
        {
            get { return this.petsHungerLevel; }
            set { this.petsHungerLevel = value; }
        }
        public int Thirst
        {
            get { return this.petsThirstLevel; }
        }
        public int Waste
        {
            get { return this.petsWasteLevel; }
        }
        public int Boredom
        {
            get { return this.petsBoredomLevel; }
        }
        public int Love
        {
            get { return this.petsLoveLevel; }
        }
        public int OverallHealth
        {
            get { return this.petsOverallHealthLevel; }
        }
        public string Name
        {
            get { return this.petsName; }
            set { this.petsName = value; }
        }


        //**********************
        //Constructors
        //**********************
        public Pet()//default constructor
        {

        }
        public Pet(string Name)
        {
            this.petsName = NameFormatting(Name);
            this.petsHungerLevel = 10;
            this.petsThirstLevel = 10;
            this.petsWasteLevel = 10;
            this.petsBoredomLevel = 10;
            this.petsLoveLevel = 10;
            this.petsOverallHealthLevel = 10;
        }

        //**********************
        //Methods
        //**********************
        public void PetFeed()//feeds pet when feed option is selected
        {
            //
            this.petsLoveLevel = this.petsLoveLevel + 1;
            this.petsWasteLevel = this.petsWasteLevel - 5;
            this.petsHungerLevel = this.petsHungerLevel + 4;
            this.petsThirstLevel = this.petsThirstLevel -2;
            this.petsBoredomLevel = this.petsBoredomLevel-1;
        }
        public void PetWater()//gives water when water option is selected
        {
            // 
            this.petsLoveLevel = this.petsLoveLevel+1;
            this.petsWasteLevel = this.petsWasteLevel-5;
            this.petsHungerLevel = this.petsHungerLevel-2;
            this.petsThirstLevel = this.petsThirstLevel+4;
            this.petsBoredomLevel = this.petsBoredomLevel-1;

        }
        public void PetPotty()//takes pet to potty when potty option is selected
        {
            //
            this.petsLoveLevel = this.petsLoveLevel -2;
            this.petsWasteLevel = this.petsWasteLevel+5;
            this.petsHungerLevel = this.petsHungerLevel-2;
            this.petsThirstLevel = this.petsThirstLevel-2;
            this.petsBoredomLevel = this.petsBoredomLevel-1;
        }
        public void PetPlay()//plays with pet when play option is selected
        {
            //
            this.petsLoveLevel = this.petsLoveLevel+2;
            this.petsWasteLevel = this.petsWasteLevel-2;
            this.petsHungerLevel = this.petsHungerLevel-2;
            this.petsThirstLevel = this.petsThirstLevel-2;
            this.petsBoredomLevel = this.petsBoredomLevel+5;
        }
        public void PetLove()//loves pet when love/relationship option is selected
        {
            //
            this.petsLoveLevel = this.petsLoveLevel+5;
            this.petsWasteLevel = this.petsWasteLevel-2;
            this.petsHungerLevel = this.petsHungerLevel-1;
            this.petsThirstLevel = this.petsThirstLevel-2;
            this.petsBoredomLevel = this.petsBoredomLevel+2;
        }
        public void PetOverall()
        {
            if (this.petsBoredomLevel >10)
            {
                this.petsBoredomLevel = 10;
            }
            if (this.petsHungerLevel > 10)
            {
                this.petsHungerLevel = 10;
            }
            if (this.petsLoveLevel > 10)
            {
                this.petsLoveLevel = 10;
            }
            if (this.petsThirstLevel > 10)
            {
                this.petsThirstLevel = 10;
            }
            if (this.petsWasteLevel > 10)
            {
                this.petsWasteLevel = 10;
            }
            if (this.petsBoredomLevel < 0)
            {
                this.petsBoredomLevel = 0;
            }
            if (this.petsHungerLevel < 0)
            {
                this.petsHungerLevel = 0;
            }
            if (this.petsLoveLevel < 0)
            {
                this.petsLoveLevel = 0;
            }
            if (this.petsThirstLevel < 0)
            {
                this.petsThirstLevel = 0;
            }
            if (this.petsWasteLevel < 0)
            {
                this.petsWasteLevel = 0;
            }
            petsOverallHealthLevel = (petsBoredomLevel + petsHungerLevel + petsLoveLevel + petsThirstLevel + petsWasteLevel) / 5;
        }//averages all other pet health stats.
        public void CurrentValue()//Prints the pets current stats on the screen
        {
            Console.Write(petsName);
            Console.WriteLine("Love =    " + petsBoredomLevel);
            Console.Write("Hunger =  " + petsBoredomLevel);
            Console.WriteLine("Thirst =  " + petsBoredomLevel);
            Console.Write("Bladder = " + petsBoredomLevel);
            Console.WriteLine("Boredom = " + petsBoredomLevel);
        }
        public string NameFormatting(string originalName)
        {
            string formattedName;
            string firstLetter;
            string remainingLetters;

            firstLetter = originalName.Substring(0, 1);
            firstLetter = firstLetter.ToUpper();
            remainingLetters = originalName.Remove(0, 1);
            remainingLetters = remainingLetters.ToLower();
            formattedName = firstLetter + remainingLetters;
            return formattedName;
        }//Formats user input for names

    }
}
