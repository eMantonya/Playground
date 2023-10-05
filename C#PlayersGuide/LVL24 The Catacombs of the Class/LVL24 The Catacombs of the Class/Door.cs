using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LVL24_The_Catacombs_of_the_Class
{
    internal class Door
    {
        private long _passcode;
        private Status _status;

        public Door(long pass)
        {
            _passcode = pass;
            _status = Status.Locked;
        }

        public Status DoorStatus => _status;

        public void Unlock()
        {
            while (true)
            {
                long pass = 0;
                try
                {
                    Console.WriteLine("Please enter the door's passcode:");
                    pass = long.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    continue;
                }
                if (pass == _passcode)
                {
                    _status = Status.Closed;
                    Console.WriteLine("You have unlocked the door.");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Passcode..");
                    continue;
                }
            }
        }
        public void Open()
        {
            if (_status == Status.Closed)
            {
                _status = Status.Opened;
                Console.WriteLine("You have opened the door.");
            }
            else if (_status == Status.Locked)
            {
                Console.WriteLine("The locked door cannot be open..");
            }
            else
            {
                Console.WriteLine("The door is already open..");
            }
        }
           
        public void Close()
        {
            if (_status == Status.Opened)
            {
                _status = Status.Closed;
                Console.WriteLine("You closed the door.");
            }
            else 
            {
                Console.WriteLine("The door is already closed..");
            }

        }

        public void Lock()
        {
            if (_status == Status.Closed)
            {
                _status = Status.Locked;
                Console.WriteLine("You have locked the door.");
            }
            else if (_status == Status.Locked)
            {
                Console.WriteLine("The door is already locked..");
            }
            else 
            {
                Console.WriteLine("Please close the door before locking"); 
            }
        }

        public void ChangePass()
        {
            Console.WriteLine("Please enter the door's passcode: ");
            long oldPass = long.Parse(Console.ReadLine());
            if (oldPass == _passcode)
            {
                Console.WriteLine("Please enter new passcode: ");
                long newPass = long.Parse(Console.ReadLine());
                _passcode = newPass;
            }
            else
            {
                Console.WriteLine("Incorrect passcode...");
            }
        }

        internal enum Status { Locked, Closed, Opened }
    }
}
