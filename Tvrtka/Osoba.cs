using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvrtka
{
    public abstract class Osoba
    {
        public abstract string Uloga { get; } 
        public string ime, prezime;
        public Osoba(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
        }
        public Osoba() : this("John","Doe") { }
        public virtual void Info()
            => Console.WriteLine(ime + " " + prezime);
    }

    public /* sealed */ class Zaposlenik : Osoba
    {
        public override string Uloga => "Zaposlenik";
        public string titula = "prof.";
        public /* sealed */ override void Info()
        {
            Console.Write(titula + " ");
            base.Info();
        }
            //=> Console.WriteLine($"{titula} {ime} {prezime}");
        public Zaposlenik(string ime, string prezime, string titula)
            : base(ime, prezime) 
            => this.titula = titula;
    }
    public class Student : Osoba
    {
        public override string Uloga => "Student";
        public string jmbag = "0031231231";
        public new void Info()
        {
            Console.Write(jmbag + " ");
            base.Info();
        }
        //=> Console.WriteLine($"{ime} {prezime} {jmbag}");
        public Student(string ime, string prezime, string jmbag)
            : base(ime, prezime)
            => this.jmbag = jmbag;
    }
    public class Honorarni : Zaposlenik
    {
        public decimal honorar;
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"\thonorar: {honorar} EUR");
        }
        //=> Console.WriteLine($"{titula} {ime} {prezime} ({honorar} EUR)");
        public Honorarni(string ime, string prezime, string titula,
            decimal honorar) : base(ime, prezime, titula)
            => this.honorar = honorar;
    }
}
