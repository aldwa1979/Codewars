using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class JohnMeeting
{
	public static string Meeting(string s) {
	
  var firstString = s.ToUpper().Split(';').ToArray();

            List<Persons> persons = new List<Persons>();

            foreach (var item in firstString)
            {
                var secondString = item.Split(':');
                persons.Add(new Persons(secondString[0], secondString[1]));
            }

            var myNewList = persons.OrderBy(n => n.Surname).ThenBy(t => t.FirstName);
            StringBuilder builder = new StringBuilder();

            foreach (var item in myNewList)
            {
                builder.Append("(" + item.Surname + ", " + item.FirstName + ")");
            }

            return builder.ToString();
    
	}
}

class Persons
    {

        public string FirstName { get; set; }
        public string Surname { get; set; }

        public Persons(string firstname, string surname)
        {
            this.FirstName = firstname;
            this.Surname = surname;
        }
    }
