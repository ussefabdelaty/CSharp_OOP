using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{ //<class modifier> -> public , internal(default)
  //to create a class -> <class modifier> + <class key_word> + <name>
  /* 
   { 
    class members =>  < fields, constants,properties,methods,events,
                      operators,indexrs,constructors,finalizers,nested type>
   }
  */
    public class employee
    {
        //constan => <access_modifier> <key word"const"> <data_type> <name> = <value>;
        public const double TAX = 0.03;

        //fields => <access_modifier> <data_type> <name> = <initial_value>;
        //<access_modifier> =>> public, private ,protected,internal;
        public string fName ;
        public string lName;
        public double wage;
        public double loggedHours;
       // public double netSalary;
    }
}
