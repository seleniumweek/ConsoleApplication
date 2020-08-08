using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lift obj = new Lift();
            obj.getInputFromUser();
        }
    }


    public class Lift
    {
        int iChoice;
        int CurPos = 0;
        int req= Convert.ToInt32((Console.ReadLine()));
        int lifts= Convert.ToInt32((Console.ReadLine()));
 
        int Source =Convert.ToInt32(( Console.ReadLine()));
        int Dest =Convert.ToInt32(( Console.ReadLine()));
        DateTime Timestamp = DateTime.Now;
        int lift_position=2;
        int Req_Lift= Convert.ToInt32((Console.ReadLine()));
        public void getInputFromUser()
        {
            if (!string.IsNullOrEmpty(Req_Lift.ToString()))
            {
                Console.WriteLine("Please enter the floor number to visit.");
                if (int.TryParse(Req_Lift.ToString(), out iChoice))
                {
                    LiftAction(iChoice);
                }
                else
                {
                    Console.WriteLine("Please enter valid input (int value)");
                    getInputFromUser();
                }
            }
        }
        private void moveUp(int DestFloor)
        {
            for (int i = CurPos; i <= DestFloor; i++)
            {
                Console.WriteLine("you are on " + i +lift_position+ " floor");
                if (i == DestFloor)
                {

                    Console.WriteLine("have a good day. bye bye");
                    CurPos = DestFloor;
                    DestFloor = 0;
                    break;
                }
            }
            getInputFromUser();


        }
        private void moveDown(int DestFloor)
        {
            for (int i = CurPos; i >= DestFloor; i--)
            {
                Console.WriteLine("you are on " + i+lift_position + " floor");
                if (i == DestFloor)
                {

                    Console.WriteLine("have a good day. bye bye");
                    CurPos = DestFloor;
                    DestFloor = 0;
                    break;
                }
            }
            getInputFromUser();
        }
        private void LiftAction(int DestFloor)
        {
            if (DestFloor > CurPos)
            {
                moveUp(DestFloor);
            }
            else if (DestFloor < CurPos)
            {
                moveDown(DestFloor);
            }
        }


    }
}
