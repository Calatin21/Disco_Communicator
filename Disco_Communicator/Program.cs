namespace Disco_Communicator {
    internal class Program {
        static void Main(string[] args) {
            Mensch stu = new() { Name = "Stu", Premiumcard = true};
            Mensch freund1 = new() { Name = "Selma", Premiumcard = true };
            Mensch freund2 = new() { Name = "Homer", Premiumcard = false };
            Disco disco = new Disco() { Name = "Studio 54"};
            Netz netz = new();
            disco.Net = netz;
            netz.Konten.Add(new NetzKonto() { Person = stu});
            netz.Konten.Add(new NetzKonto() { Person = freund1});
            netz.Konten.Add(new NetzKonto() { Person = freund2});
            disco.DiscoEvent += disco.Betreten;
            disco.DiscoEvent += disco.Verlassen;
            

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
            disco.AddBesucher(freund1);
            disco.AddBesucher(freund2);
            netz.ZeigeAlleNachrichten();
        }
    }
}