using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    interface ControllerInterface
    {
        //Method to verify Username and check for password, 
         string getPassword();

        string checkPassword(string username);

        string getUserName(string username);

        string getQuestion();

        string getAnswer();

        void Register(string firstName, string lastName, string email, string phoneNumber, string username, string password, string question, string answer, string cardNum, string cardType, string address);

    }
}
