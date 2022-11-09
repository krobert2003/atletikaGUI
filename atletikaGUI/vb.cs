using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atletikaGUI
{
    internal class vb
    {
        readonly string Versenyszam;
        readonly string Nem;
        readonly int NemzetKod;
        readonly string VersenyzoNev;
        readonly string Eredmeny;
        readonly string Csucs;
        readonly int Helyezes;
        readonly int NemzetId;
        readonly string Nemzet;

        public string Versenyszam1 => Versenyszam;

        public string Nem1 => Nem;

        public int NemzetKod1 => NemzetKod;

        public string VersenyzoNev1 => VersenyzoNev;

        public string Eredmeny1 => Eredmeny;

        public string Csucs1 => Csucs;

        public int Helyezes1 => Helyezes;

        public int NemzetId1 => NemzetId;

        public string Nemzet1 => Nemzet;



        public vb(string Versenyszam, string Nem, int NemzetKod, string VersenyzoNev, string Eredmeny, string Csucs, int Helyezes ,int NemzetId, string Nemzet)
        {
            this.Versenyszam = Versenyszam;
            this.Nem=  Nem;
            this.NemzetKod = NemzetKod;
            this.VersenyzoNev = VersenyzoNev;
            this.Eredmeny = Eredmeny;
            this.Csucs = Csucs;
            this.Helyezes= Helyezes;
            this.Nemzet = Nemzet;
            this.NemzetId = NemzetId;
        }

       
    }
}
