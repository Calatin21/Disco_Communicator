namespace Disco_Communicator {
    internal class NetzKonto {
        public Mensch Person { get; set; }
        public List<Nachricht> Nachrichten { get; set; } = new();
    }
}
