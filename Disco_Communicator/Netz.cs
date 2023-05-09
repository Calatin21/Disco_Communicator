namespace Disco_Communicator {
    internal class Netz {
        public List<NetzKonto> Konten { get; set; } = new();
        public void ZeigeAlleNachrichten() {
            foreach (NetzKonto item in Konten) {
                Console.WriteLine($"Nachrichten von: {item.Person.Name}");
                foreach (string element in item.Nachrichten) {
                    Console.WriteLine(element);
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }
        }
        public void Weiterleiten(Mensch sender, Ereignis grund, string nachricht) {
            foreach (NetzKonto item in Konten) {
                if (item.Person != sender) {
                    item.Nachrichten.Add($"Sender: {sender.Name}\tGrund: {grund}\nNachricht: {nachricht}");
                }                
            }
        }
    }
}
