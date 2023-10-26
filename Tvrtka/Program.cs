using Tvrtka;

//Osoba w = new Osoba();
Zaposlenik x = new Zaposlenik("Edgar","Poe","dr.sc.");
Student y = new Student("Ann","Horvat","0012345677");
Honorarni z = new Honorarni("Ivo","Ivic","mr.sc.",1000.123M);

IspisSvih(x,y,z);
y.Info();
IspisUloge(x);
IspisUloge(y);
IspisUloge(z);

static void IspisUloge(Osoba a)
	=> Console.WriteLine(a.Uloga);

static void IspisSvih(params Osoba[] a)
{
    Console.WriteLine("Ispis podataka:");
	/* for (int i = 0; i < a.Length; i++)
	{
		a[i].Info();
	} */
	foreach (var o in a)
		o.Info();
}