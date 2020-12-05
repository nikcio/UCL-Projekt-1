using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCL_Projekt_1.Models {
    public class Kunde : IPerson {
        public Kunde(string navn, int telefon, string email, int kunde_Id, bool er_sælger, bool er_køber) {
            Navn = navn;
            Telefon = telefon;
            Email = email;
            Kunde_Id = kunde_Id;
            Er_sælger = er_sælger;
            Er_køber = er_køber;
        }

        public string Navn { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }
        public int Kunde_Id { get; set; }
        public Nullable<bool> Er_sælger { get; set; }
        public Nullable<bool> Er_køber { get; set; }

    }
}
