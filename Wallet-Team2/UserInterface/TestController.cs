using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public class TestController
    {
        public List<Profile> profileList = new List<Profile>();
        public List<string> testAddresses = new List<string>();
        public List<string> instrumentInfo = new List<string>();
        public string instrumentType;
        public List<List<string>> instrumentList = new List<List<string>>();
        public double purchaseAmount;
        public bool open = true;

        public TestController()
        {
        }

        public List<List<string>> getList()
        {
            return instrumentList;
        }

        public double getAmount()
        {
            return purchaseAmount;
        }

        public List<string> getInstrumentInfo(string username, string ID)
        {
            foreach(List<string> l in instrumentList)
            {
                if (l[0] == ID)
                    return instrumentInfo;

            }
            return null;
        }


        public void sendInfo(List<string> info, string t)
        {
            instrumentInfo = info;
            instrumentType = t;
            instrumentList.Add(instrumentInfo);
        }

        public string checkPassword(string username)
        {
            foreach (Profile p in profileList)
            {
                if (username == p.username)
                {
                    return p.password;
                }
            }
            return "######"; //using this instead of null
        }

        public string getUsername(string username)
        {
            foreach (Profile p in profileList)
            {
                if (username == p.username)
                {
                    return p.username;
                }
            }
            return "######"; //using this instead of null
        }

        public string getPassword(string username)
        {
            foreach (Profile p in profileList)
            {
                if (p.username == username)
                {
                    return p.password;
                }
            }
            return null;
        }

        public string getQuestion(string username)
        {
            foreach(Profile p in profileList)
            {
                if(username == p.username)
                {
                    return p.question;
                }
            }
            return null;
        }

        public string getAnswer(string username)
        {
            foreach (Profile p in profileList)
            {
                if (username == p.username)
                {
                    return p.answer;
                }
            }
            return null;
        }

        public void Register(string firstName, string lastName, string email, string phoneNumber, string username, string password, string question, string answer, string address)
        {
            testAddresses.Add(address);
            List<string> addresses = new List<string>();
            addresses.Add(address);
            Profile p = new Profile(email, addresses, firstName, lastName, username, password, question, answer, phoneNumber);
            profileList.Add(p); // adding profile to T
        }





    }
}