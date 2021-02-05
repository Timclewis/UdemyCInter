using System;
namespace Properties
{ // ensure that class is always in a valid state
    public class Persons
    {
        // properties
        public DateTime Birthdate { get; private set; }
        

        //construcor with parameter
        public Persons(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
       // calculated properties (with some logic)
        public int Age
        {
            get
            {
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days/365;

                return years;
            }
          


        }

    }
}