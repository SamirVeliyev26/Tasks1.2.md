using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTask1._2
{
    internal class Hotel
    {

        private int _id;
        private int _RoomCount;
        private string _HotelName;
        private string _address;
        private int _RoomPrice;


        public int RoomCount 
        {
            get 
            {
                return _RoomCount;
            }
            set 
            { 
                if(value>=0 && value <= 200)
                {
                    _RoomCount = value;

                }

                else
                {
                    Console.WriteLine("Siz isdediyiniz qeder qala bilmersiz.");
                }


            }
        
        
        
        }

        public int RoomPrice 
        {



            get 
            {
                return _RoomPrice;
            }
            set 
            { 
              if (value>60 && value < 150)
              {

                    _RoomPrice = value;

              }
                else
                {
                    Console.WriteLine("Siz istediyiniz qiymete otaq yoxdur.");
                }



            }
        }

        public int Hotel2 
        { 
            get 
            {
                return RoomPrice * RoomCount;
               
            }

            



        }

        public void Hotel3()
        {

            Console.WriteLine($"Sizin hotele borcunuz {Hotel2} azn dir");

        }

        




    }

}
