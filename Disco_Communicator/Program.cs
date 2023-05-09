namespace Disco_Communicator {
    internal class Program {
        static void Main(string[] args) {
            DiscoBesucher stu = new() { Name = "Stu", Premiumcard = true};
            Mensch freund1 = new() { Name = "Selma" };
            Mensch freund2 = new() { Name = "Homer" };
            Disco disco = new Disco() { Name = "Studio 54"};
            Netz netz = new();
            netz.Konten.Add(new NetzKonto() { Person = stu});
            netz.Konten.Add(new NetzKonto() { Person = freund1});
            netz.Konten.Add(new NetzKonto() { Person = freund2});
            Kommunikator kommunikator = new() { Net = netz};
            disco.DiscoEvent += kommunikator.Betreten;
            disco.DiscoEvent += kommunikator.Verlassen;
            

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nachrichten Bevor Disco besuch");
            Console.ForegroundColor = ConsoleColor.Gray;
            netz.ZeigeAlleNachrichten();
            disco.AddBesucher(stu);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nachrichten Nach Disco besuch");
            Console.ForegroundColor = ConsoleColor.Gray;
            netz.ZeigeAlleNachrichten();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nachrichten nach Disco verlassen");
            Console.ForegroundColor = ConsoleColor.Gray;
            disco.RemoveBesucher(stu);
            netz.ZeigeAlleNachrichten();
        }
    }
}