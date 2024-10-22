namespace lab5
{
    public interface IDocument
    {
        string ID { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Date_Of_Birth { get; set; }
        string Nationality { get; set; }
        bool sex { get; set; } // True for man, False for woman
        string Date_Of_Issue { get; set; }
        string Date_Of_expire { get; set; }
        string Individual_tax_number { get; set; }

        int Passport_Expired_in();
    }
}
