namespace WebApplication1_Prosjekt1.Model
{
    public class Sykdom
    {
        public int id { get; set; }
        public int høyde { get; set; }
        public int vekt { get; set; }

        public bool feber { get; set; }
        public bool hodepine { get; set; }
        public bool hoste { get; set; }
        public bool kjønn { get; set; }

        public bool smakeOgLukte { get; set; }
    }
}
