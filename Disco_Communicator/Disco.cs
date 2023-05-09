namespace Disco_Communicator {
    internal class Disco {
        public event EventHandler<DiscoEventArgs> DiscoEvent;
        public string Name { get; set; }
        public List<Mensch> Besucher = new();
        public Netz Net { get; set; }
        public void AddBesucher(Mensch besucher) {
            Besucher.Add(besucher);
            if (((DiscoBesucher)besucher).Premiumcard) {
                this.DiscoEvent(this, new DiscoEventArgs() { Message = $"Disco {this.Name} Betreten", Sender = besucher, Grund = Ereignis.Betreten });
            }
        }
        public void RemoveBesucher(Mensch besucher) {
            Besucher.Remove(besucher);
            if (((DiscoBesucher)besucher).Premiumcard) {
                this.DiscoEvent(this, new DiscoEventArgs() { Message = $"Disco {this.Name} Verlassen", Sender = besucher, Grund = Ereignis.Verlassen });
            }
        }
        public void Betreten(object source, DiscoEventArgs e) {
            if (e.Grund == Ereignis.Betreten) {
                Net.Weiterleiten(e.Sender, e.Grund, e.Message);
            }
        }
        public void Verlassen(object source, DiscoEventArgs e) {
            if (e.Grund == Ereignis.Verlassen) {
                Net.Weiterleiten(e.Sender, e.Grund, e.Message);
            }
        }
    }
}
