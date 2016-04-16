using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    //Using the FlagAttribute for an enum
    class Listing2_1 : IExecuter
    {
        public void Execute(string[] args)
        {
            Days weekday = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday;
            Days weekend = Days.Saturday | Days.Sunday;
            Days trainingdaysA = Days.Tuesday | Days.Thursday | Days.Sunday; //weekdays and weekend
            Days trainingdaysB = Days.Wednesday; //weekday only
            Days trainingdaysC = Days.Saturday; //weekend only
            
            bool isMondayWeekday = (weekday & Days.Monday) == Days.Monday;
            bool isTuesdayWeekday = (weekday & Days.Tuesday) == Days.Tuesday;
            bool isWednesdayWeekday = (weekday & Days.Wednesday) == Days.Wednesday;
            bool isThursdayWeekday = (weekday & Days.Thursday) == Days.Thursday;
            bool isFridayWeekday = (weekday & Days.Friday) == Days.Friday;
            bool isSaturdayWeekday = (weekday & Days.Saturday) == Days.Saturday;
            bool isSundayWeekday = (weekday & Days.Sunday) == Days.Sunday;
            Console.WriteLine("is Monday weekday? " + isMondayWeekday);
            Console.WriteLine("is Tuesday weekday? " + isTuesdayWeekday);
            Console.WriteLine("is Wednesday weekday? " + isWednesdayWeekday);
            Console.WriteLine("is Thurday weekday? " + isThursdayWeekday);
            Console.WriteLine("is Friday week? " + isFridayWeekday);
            Console.WriteLine("is Saturday weekday? " + isSaturdayWeekday);
            Console.WriteLine("is Sunday weekday? " + isSundayWeekday);
            Console.WriteLine();

            bool isMondayWeekend = (weekend & Days.Monday) == Days.Monday;
            bool isTuesdayWeekend = (weekend & Days.Tuesday) == Days.Tuesday;
            bool isWednesdayWeekend = (weekend & Days.Wednesday) == Days.Wednesday;
            bool isThursdayWeekend = (weekend & Days.Thursday) == Days.Thursday;
            bool isFridayWeekend = (weekend & Days.Friday) == Days.Friday;
            bool isSaturdayWeekend = (weekend & Days.Saturday) == Days.Saturday;
            bool isSundayWeekend = (weekend & Days.Sunday) == Days.Sunday;
            Console.WriteLine("is Monday weekend? " + isMondayWeekend);
            Console.WriteLine("is Tuesday weekend? " + isTuesdayWeekend);
            Console.WriteLine("is Wednesday weekend? " + isWednesdayWeekend);
            Console.WriteLine("is Thurday weekend? " + isThursdayWeekend);
            Console.WriteLine("is Friday weekend? " + isFridayWeekend);
            Console.WriteLine("is Saturday weekend? " + isSaturdayWeekend);
            Console.WriteLine("is Sunday weekend? " + isSundayWeekend);
            Console.WriteLine();

            bool isWeekendInWeekday = (weekday & weekend) == weekend;
            bool isWeekdayInWeekend = (weekend & weekday) == weekday;
            Console.WriteLine("is weekend in weekdays? " + isWeekendInWeekday);
            Console.WriteLine("is weekdays in weekend? " + isWeekdayInWeekend);
            Console.WriteLine();
            
            bool trainingAOnlyWeekdays = (weekday & trainingdaysA) == trainingdaysA;
            bool trainingAOnlyWeekends = (weekend & trainingdaysA) == trainingdaysA;
            bool trainingAWeekdayOrWeekends = ((weekday | weekend) & trainingdaysA) == trainingdaysA;
            Console.WriteLine("Is trainingA days only in weekdays? " + trainingAOnlyWeekdays);
            Console.WriteLine("Is trainingA days only in weekend? " + trainingAOnlyWeekends);
            Console.WriteLine("Is trainingA days in weekdays or weekends? " + trainingAWeekdayOrWeekends);
            Console.WriteLine();

            bool trainingBOnlyWeekdays = (weekday & trainingdaysB) == trainingdaysB;
            bool trainingBOnlyWeekends = (weekend & trainingdaysB) == trainingdaysB;
            bool trainingBWeekdayOrWeekends = ((weekday | weekend) & trainingdaysB) == trainingdaysB;
            Console.WriteLine("Is trainingB days only in weekdays? " + trainingBOnlyWeekdays);
            Console.WriteLine("Is trainingB days only in weekend? " + trainingBOnlyWeekends);
            Console.WriteLine("Is trainingB days in weekdays or weekends? " + trainingBWeekdayOrWeekends);
            Console.WriteLine();

            bool trainingCOnlyWeekdays = (weekday & trainingdaysC) == trainingdaysC;
            bool trainingCOnlyWeekends = (weekend & trainingdaysC) == trainingdaysC;
            bool trainingCWeekdayOrWeekends = ((weekday | weekend) & trainingdaysC) == trainingdaysC;
            Console.WriteLine("Is trainingC days only in weekdays? " + trainingCOnlyWeekdays);
            Console.WriteLine("Is trainingC days only in weekend? " + trainingCOnlyWeekends);
            Console.WriteLine("Is trainingC days in weekdays or weekends? " + trainingCWeekdayOrWeekends);
            Console.WriteLine();
        }

        
    }

    [Flags]
    enum Days
    {
        //Define enumeration constants in powers of two, that is, 1, 2, 4, 8, and so on.
        None = 0x0,
        Monday = 0x1,
        Tuesday = 0x2,
        Wednesday = 0x4,
        Thursday = 0x8,
        Friday = 0x10,
        Saturday = 0x20,
        Sunday = 0x40,
    } 
    //power of | decimal	|	Hexamal
    //0          1  		 	Hex = 00000001 
    //1          2 		 	    Hex = 00000002 
    //2          4  		 	Hex = 00000004 
    //3          8  		 	Hex = 00000008 
    //4          16  			Hex = 00000010 
    //5          32  			Hex = 00000020 
    //6          64  			Hex = 00000040 
    //7          128  	 	    Hex = 00000080 
    //8          256  	 	    Hex = 00000100 
    //9          512  	 	    Hex = 00000200 
    //10         1024  	 	    Hex = 00000400 
    //11         2048  	 	    Hex = 00000800 
    //12         4096  	 	    Hex = 00001000 
    //13         8192  	 	    Hex = 00002000 
    //14         16384  	 	Hex = 00004000 
    //15         32768  	 	Hex = 00008000 
    //16         65536  	 	Hex = 00010000 
    //17         131072  		Hex = 00020000
    //18         262144  		Hex = 00040000
    //19         524288  		Hex = 00080000
    //20         1048576   	    Hex = 00100000 
    //21         2097152   	    Hex = 00200000
    //22         4194304   	    Hex = 00400000
    //23         8388608   	    Hex = 00800000
    //24         16777216  	    Hex = 01000000 
    //25         33554432  	    Hex = 02000000
    //26         67108864  	    Hex = 04000000
    //27         134217728 	    Hex = 08000000
    //28         268435456 	    Hex = 10000000 
    //29         536870912 	    Hex = 20000000
    //30         1073741824	    Hex = 40000000
    //31         2147483648	    Hex = 80000000
    //32         4294967296	    Hex = 100000000
}
