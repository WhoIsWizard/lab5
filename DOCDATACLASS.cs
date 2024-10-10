using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class DOCDATACLASS
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Date_Of_Birth { get; set; }
        public string Nationality { get; set; }
        public bool sex { get; set; }                        // True for man,   False for woman
        public string Date_Of_Issue { get; set; }
        public string Date_Of_expire { get; set; }
        public string Individual_tax_number { get; set; }

        public int Passport_Expired_in()
        {
            DateTime expireDate = DateTime.Parse(Date_Of_expire);
            DateTime currentDate = DateTime.Now;

            // Calculate full years between the current date and expiration date
            int years = (expireDate.Year - currentDate.Year);

            // Adjust if expiration date hasn't occurred yet this year
            if (expireDate < currentDate.AddYears(years))
            {
                years--;
            }

            return years;
        }

        public DOCDATACLASS()
        {

        }

        public DOCDATACLASS(string ID, string name, string surname, string date_of_birth, string nationality,
            bool sex, string date_of_issue, string date_of_expire, string individual_tax_number)
        {
            this.ID = ID;
            Name = name;
            Surname = surname;
            Date_Of_Birth = date_of_birth;
            Nationality = nationality;
            this.sex = sex;
            Date_Of_Issue = date_of_issue;
            Date_Of_expire = date_of_expire;
            Individual_tax_number = individual_tax_number;
        }


    }
}