namespace SystemBolagetJson.Models
{
    public class artiklar
    {
        private artiklarArtikel[] artikelField;

        [System.Xml.Serialization.XmlElementAttribute("artikel")]
        public artiklarArtikel[] artikel
        {
            get => artikelField;
            set => artikelField = value;
        }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class artiklarArtikel
    {
        private uint nrField;

        private uint artikelidField;

        private uint varnummerField;

        private string namnField;

        private string namn2Field;

        private decimal prisinklmomsField;

        private decimal volymimlField;

        private decimal prisPerLiterField;

        private System.DateTime saljstartField;

        private bool utgåttField;

        private string varugruppField;

        private string typField;

        private string stilField;

        private string forpackningField;

        private string forslutningField;

        private string ursprungField;

        private string ursprunglandnamnField;

        private string producentField;

        private string leverantorField;

        private string argangField;

        private string provadargangField;

        private string alkoholhaltField;

        private string sortimentField;

        private string sortimentTextField;

        private bool ekologiskField;

        private bool etisktField;

        private bool koscherField;

        private string ravarorBeskrivningField;

        public uint nr
        {
            get => nrField;
            set => nrField = value;
        }

        public uint Artikelid
        {
            get => artikelidField;
            set => artikelidField = value;
        }

        public uint Varnummer
        {
            get => varnummerField;
            set => varnummerField = value;
        }

        public string Namn
        {
            get => namnField;
            set => namnField = value;
        }

        public string Namn2
        {
            get => namn2Field;
            set => namn2Field = value;
        }

        public decimal Prisinklmoms
        {
            get => prisinklmomsField;
            set => prisinklmomsField = value;
        }

        public decimal Volymiml
        {
            get => volymimlField;
            set => volymimlField = value;
        }

        public decimal PrisPerLiter
        {
            get => prisPerLiterField;
            set => prisPerLiterField = value;
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Saljstart
        {
            get => saljstartField;
            set => saljstartField = value;
        }

        public bool Utgått
        {
            get => utgåttField;
            set => utgåttField = value;
        }

        public string Varugrupp
        {
            get => varugruppField;
            set => varugruppField = value;
        }

        public string Typ
        {
            get => typField;
            set => typField = value;
        }

        public string Stil
        {
            get => stilField;
            set => stilField = value;
        }

        public string Forpackning
        {
            get => forpackningField;
            set => forpackningField = value;
        }

        public string Forslutning
        {
            get => forslutningField;
            set => forslutningField = value;
        }

        public string Ursprung
        {
            get => ursprungField;
            set => ursprungField = value;
        }

        public string Ursprunglandnamn
        {
            get => ursprunglandnamnField;
            set => ursprunglandnamnField = value;
        }

        public string Producent
        {
            get => producentField;
            set => producentField = value;
        }

        public string Leverantor
        {
            get => leverantorField;
            set => leverantorField = value;
        }

        public string Argang
        {
            get => argangField;
            set => argangField = value;
        }

        public string Provadargang
        {
            get => provadargangField;
            set => provadargangField = value;
        }

        public string Alkoholhalt
        {
            get => alkoholhaltField;
            set => alkoholhaltField = value;
        }

        public string Sortiment
        {
            get => sortimentField;
            set => sortimentField = value;
        }

        public string SortimentText
        {
            get => sortimentTextField;
            set => sortimentTextField = value;
        }

        public bool Ekologisk
        {
            get => ekologiskField;
            set => ekologiskField = value;
        }

        public bool Etiskt
        {
            get => etisktField;
            set => etisktField = value;
        }

        public bool Koscher
        {
            get => koscherField;
            set => koscherField = value;
        }

        public string RavarorBeskrivning
        {
            get => ravarorBeskrivningField;
            set => ravarorBeskrivningField = value;
        }
    }
}