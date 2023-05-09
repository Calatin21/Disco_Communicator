namespace Disco_Communicator {
    internal class Disco {
        public event EventHandler<DiscoEventArgs> DiscoEvent;
        public string Name { get; set; }
        public List<Mensch> Besucher = new();
        public void AddBesucher (Mensch besucher) {
            Besucher.Add(besucher);
            if (((DiscoBesucher)besucher).Premiumcard) {
                this.Event($"Disco {this.Name} Betreten", besucher, Ereignis.Betreten);
            }
        }
        public void RemoveBesucher(Mensch besucher) {
            Besucher.Remove(besucher);
            if (((DiscoBesucher)besucher).Premiumcard) {
                this.Event($"Disco {this.Name} Verlassen", besucher, Ereignis.Verlassen);
            }
        }
        public void Event(string message, Mensch sender, Ereignis ereignis) {
            if (DiscoEvent != null) {
                DiscoEvent(this, new DiscoEventArgs() { Message = message, Sender = sender, Grund = ereignis});
            }
        }
    }
}
