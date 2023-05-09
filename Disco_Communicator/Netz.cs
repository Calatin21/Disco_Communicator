namespace Disco_Communicator {
    internal class Netz {
        public List<NetzKonto> Konten { get; set; } = new();
        public void ZeigeAlleNachrichten() {
            foreach (NetzKonto item in Konten) {
                Console.WriteLine($"Nachrichten von: {item.Person.Name}");
                foreach (Nachricht element in item.Nachrichten) {
                    Console.WriteLine($"Sender: {element.Sender.Name}\nGrund: {element.Grund}\nText: {element.Text}");
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }
        }
        public void Weiterleiten(Mensch sender, Ereignis grund, string nachricht) {
            foreach (NetzKonto item in Konten) {
                if (item.Person != sender) {
                    item.Nachrichten.Add(new Nachricht() { Sender = sender, Grund = grund, Text = nachricht });
                }                
            }
        }
    }
}
