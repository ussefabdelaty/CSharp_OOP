namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 05, 01, 08 , 30,00) ;
            dt = dt.AddDays(10) ;    
            Console.WriteLine(dt);   

          /*  DigitalSize size = new DigitalSize(60000);
            size = size.AddBit(8);
            Console.WriteLine(size.Bit);
            Console.WriteLine(size.Byte);
            Console.WriteLine(size.GB);
            Console.WriteLine(size.KB);
            Console.WriteLine(size.TB);
          */



            /* Student st = new Student();
           //  st.id = 1;  
            // st.show();
            Console.WriteLine(st.id);
            */
            Console.ReadKey();
        }

       


      /*  struct Student 
        {
            public int id ;

           public void show ()
            {
                Console.WriteLine("this is a student");
                    
            }
        }
      */

      /*  struct DigitalSize
        {
            private long bit;

            public string Bit  => $"{(bit / BitsInBit):N0} Bit";
            public string Byte => $"{(bit / BitsInByte):N0} byte";
            public string KB   => $"{(bit / BitsInKByte):N0} KB";
            public string MB   => $"{(bit / BitsInMByte):N0} MB";
            public string GB   => $"{(bit / BitsInGByte):N0} GB";
            public string TB   => $"{(bit / BitsInTByte):N0} TB";

            private const long BitsInBit  =1;
            private const long BitsInByte =8;
            private const long BitsInKByte = BitsInByte *  1024;
            private const long BitsInMByte = BitsInKByte * 1024;
            private const long BitsInGByte = BitsInMByte * 1024;
            private const long BitsInTByte = BitsInGByte * 1024; 

            public DigitalSize(long initialvalue)
            {
                this.bit = initialvalue;
            }

            private DigitalSize add( long value , long scale)
            {
                return new DigitalSize(value * scale);
            }

            public DigitalSize AddBit(long bit)
            {
                return add(bit, BitsInBit);
            }
            public DigitalSize AddByte(long bit)
            {
                return add(bit, BitsInByte);
            }
            public DigitalSize AddKB(long bit)
            {
                return add(bit, BitsInKByte);
            }
            public DigitalSize AddMB(long bit)
            {
                return add(bit, BitsInMByte);
            }
            public DigitalSize AddGB(long bit)
            {
                return add(bit, BitsInGByte);
            }
            public DigitalSize AddTB(long bit)
            {
                return add(bit, BitsInTByte);
            }

        }
      */
    }
}