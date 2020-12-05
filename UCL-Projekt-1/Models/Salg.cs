using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCL_Projekt_1.Models {
    public class Salg {
        public Salg(int salgs_Id, DateTime dato, int pris, int mægler_Id, int bolig_Id) {
            Salgs_Id = salgs_Id;
            Dato = dato;
            Pris = pris;
            Mægler_Id = mægler_Id;
            Bolig_Id = bolig_Id;
        }

        public int Salgs_Id { get; set; }
        public DateTime Dato { get; set; }
        public int Pris { get; set; }
        public int Mægler_Id { get; set; }
        public int Bolig_Id { get; set; }
    }
}
