namespace Disco_Communicator {
    internal class Kommunikator {
        public Netz Net { get; set; }
        public void Betreten(object source, DiscoEventArgs e) {
            if (e.Grund == Ereignis.Betreten) {
                Net.Weiterleiten(e.Sender, e.Grund, e.Message);
            }
        }
        public void Verlassen(object source, DiscoEventArgs e) {
            if (e.Grund == Ereignis.Verlassen) {
                Net.Weiterleiten(e.Sender, e.Grund, e.Message); }
        }
    }
}
