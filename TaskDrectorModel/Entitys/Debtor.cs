using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDrectorModel.Entitys
{
    public class Debtor
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public Debtor(int ıd, string fullName, DateTime birthDay, string phone, string email, string address, int debt)
        {
            Id = ıd;
            FullName = fullName;
            BirthDay = birthDay;
            Phone = phone;
            Email = email;
            Address = address;
            Debt = debt;
        }

        public DateTime BirthDay { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public int Debt { get; set; }

        public override string ToString()
        {

            return $"{this.FullName} {this.BirthDay.ToShortDateString()} {this.Phone} {this.Email} {this.Address} {this.Debt}";

        }

        public Debtor()
        {
        }
    }
}
