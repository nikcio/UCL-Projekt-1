namespace UCL_Projekt_1.Models
{
    public class Ejendomsmægler : IPerson
    {
        public Ejendomsmægler(int mægler_Id, string navn, int telefon, string email)
        {
            Mægler_Id = mægler_Id;
            Navn = navn;
            Telefon = telefon;
            Email = email;
        }

        public int Mægler_Id { get; set; }
        public string Navn { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }
    }
}
