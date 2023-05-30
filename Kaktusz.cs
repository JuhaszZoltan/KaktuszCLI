namespace KaktuszCLI
{
    internal class Kaktusz
    {
        public string Nev { get; set; }
        public string TudomanyosNev { get; set; }
        public string TermesztesiNehezseg { get; set; }
        public int VizIgeny { get; set; }
        public int FenyIgeny { get; set; }

        public Kaktusz(string s)
        {
            var v = s.Split(';');
            Nev = v[0];
            TudomanyosNev = v[1];
            TermesztesiNehezseg = v[2];
            VizIgeny = int.Parse(v[3]);
            FenyIgeny = int.Parse(v[4]);
        }
    }
}
