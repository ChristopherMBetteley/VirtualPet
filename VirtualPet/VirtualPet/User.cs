using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class User
    {
        //**********************
        //fields
        //**********************
        private string userName;

        //**********************
        //Properties
        //**********************
        public string Name
        {
            get { return this.userName; }
            set { this.userName = value; }
        }


        //**********************
        //Constructors
        //**********************
        public User()//default Constructor
        {
        }
        public User(string Name)
        {
            this.userName = nameFormatting(Name);
        }


        //**********************
        //Methods
        //**********************
        public string nameFormatting(string originalName)
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
        }
    }
}
