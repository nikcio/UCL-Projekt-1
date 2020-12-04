using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCL_Projekt_1.Models {
    public class Bolig {
        public Bolig(int bolig_Id, int udbuds_pris, string boligtype, int bolig_areal, int grund_areal, string addresse, int kunde_køber, int kunde_sælger, int mægler_Id, bool solgt) {
            Bolig_Id = bolig_Id;
            Udbuds_pris = udbuds_pris;
            Boligtype = boligtype;
            Bolig_areal = bolig_areal;
            Grund_areal = grund_areal;
            Addresse = addresse;
            Kunde_køber = kunde_køber;
            Kunde_sælger = kunde_sælger;
            Mægler_Id = mægler_Id;
            Solgt = solgt;
        }

        public int Bolig_Id { get; set; }
        public int Udbuds_pris { get; set; }
        public string Boligtype { get; set; }
        public int Bolig_areal { get; set; }
        public int Grund_areal { get; set; }
        public string Addresse { get; set; }
        public Nullable<int> Kunde_køber { get; set; }
        public Nullable<int> Kunde_sælger { get; set; }
        public Nullable<int> Mægler_Id { get; set; }
        public bool Solgt { get; set; }
    }
}
