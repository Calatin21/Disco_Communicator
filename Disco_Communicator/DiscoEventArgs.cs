namespace Disco_Communicator {
    public enum Ereignis { Betreten, Verlassen };
    internal class DiscoEventArgs : EventArgs {
        public Mensch Sender { get; set; }
        public Ereignis Grund { get; set; }
        public string Message { get; set; }
    }
}
