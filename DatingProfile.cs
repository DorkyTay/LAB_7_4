using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_7_4
{
    class DatingProfile
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string bio { get; set; }
        public DatingProfile(string firstName, string lastName, int age, string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
        }

        public void WriteBio(string inputBio)
        {
            this.bio = inputBio;
        }
        public void ReadMessage()
        {

        }
        public void SendMessage(string MessageTitle, string MessageData, DatingProfile toProfile)
        {

        }


    }

}