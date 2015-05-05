using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserInterface
{
    public class TestUserProfileData
    {
        public List<Profile> profileList = new List<Profile>();
        public List<string> testAddresses = new List<string>();
        public Profile p;
        public string email;
        public string firstName;
        public string lastName;
        public string username;
        public string password;
        public string question;
        public string answer;
        public string phone;


        public void AddProfile(string email, List<string> addresses, string firstName, string lastName, string username, string password, string question, string answer, string phoneNumber)
        {


            Profile test = new Profile(email, addresses, firstName, lastName, username, password, question, answer, phoneNumber);
            profileList.Add(test);
        }

        public void AddToList(Profile testProfile)
        {
            profileList.Add(testProfile);
        }

    }

    public class Profile
    {
        public Profile(string email, List<string> addresses, string firstName, string lastName, string username, string password, string question, string answer, string phoneNumber)
        {
            this.email = email;
            this.addresses = addresses;
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.password = password;
            this.question = question;
            this.answer = answer;
            this.phoneNumber = phoneNumber;
        }
        public string email;
        public List<string> addresses = new List<string>();
        public string firstName;
        public string lastName;
        public string username;
        public string password;
        public string question;
        public string answer;
        public string phoneNumber;

        public Profile createProfileFromTextFile()
        {
            try
            {
                using (StreamReader reader = File.OpenText("testFile.txt"))
                {
                    string line;
                    string[] items = new string[17];
                    int i = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        items[i] = line;
                        i++;
                    }
                    List<string> addresses = new List<string>();
                    addresses.Add(items[5] + ", " + items[6] + ", " + items[7] + ", " + items[8]);
                    Profile p = new Profile(items[2], addresses, items[3], items[4], items[0], items[1], items[10], items[11], items[9]);
                    return p;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }​
    }



}


