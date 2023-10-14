namespace _20_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var month in Enum.GetNames(typeof(Month)))
            {
                Console.WriteLine($"{month} = {(int)Enum.Parse(typeof(Month), month)} "); 
            }

            foreach (var month in Enum.GetValues(typeof(Month)))
            {
                Console.WriteLine($"{month.ToString()} = {(int) month} ");
            }
            //============================================================
            /*  var month =2;
              if (Enum.IsDefined(typeof(Month) , month))
              {
                  Console.WriteLine((Month)month);
              }
              else { Console.WriteLine("invalid!"); }
            */
            //==========================================================
            // Console.WriteLine(Enum.Parse(typeof(Month) , month));
            //==========================================================
            //  if (Enum.TryParse(month , out Month nameofthemonth))
            //   { Console.WriteLine(nameofthemonth); }
            //=============================================================
            /*  var day = (Day.Saturday & Day.Sunday);
              if (day.HasFlag(Day.WeekEnd))
              {
                  Console.WriteLine("enjoy!");
              }
              else { Console.WriteLine("enjooooy!"); }
            */
            /* Console.WriteLine((int) Month.feb);
             Console.WriteLine(Month.dec);
            */
            Console.WriteLine();
        }
    }

     // #Simple Enum;
      enum Month : int // int it's the default value 
                      //  you can change it to long or any other types 
                      // it's doesn't accept string as Data type
      {
          Jan = 1,    
          feb,
          march,
          abril,
          may,
          jun,
          jul,
          aug,
          sep,
          oct,
          nov,
          dec
      }
    
/*
    [Flags]
    enum Day
    {
        None =          0b_0000_0000,   //0
        Monday =        0b_0000_0001,  //1
        Tuseday =       0b_0000_0010,  //2,
        wedensday =     0b_0000_0100 , //4,
        Thursday =      0b_0000_1000 , //8,
        Friday =        0b_0001_0000,  //16
        Saturday =      0b_0010_0000, //32,  
        Sunday =        0b_0100_0000, //64,
        BussDay = Monday | Tuseday | wedensday | Thursday | Friday ,
        WeekEnd = Saturday | Sunday

    }
*/

}