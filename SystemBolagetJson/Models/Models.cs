namespace SystemBolagetJson.Models
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class artiklar
    {
        private artiklarArtikel[] artikelField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("artikel")]
        public artiklarArtikel[] artikel
        {
            get => this.artikelField;
            set => this.artikelField = value;
        }
    }

    /// <remarks/>
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

        /// <remarks/>
        public uint nr
        {
            get => this.nrField;
            set => this.nrField = value;
        }

        /// <remarks/>
        public uint Artikelid
        {
            get => this.artikelidField;
            set => this.artikelidField = value;
        }

        /// <remarks/>
        public uint Varnummer
        {
            get => this.varnummerField;
            set => this.varnummerField = value;
        }

        /// <remarks/>
        public string Namn
        {
            get => this.namnField;
            set => this.namnField = value;
        }

        /// <remarks/>
        public string Namn2
        {
            get => this.namn2Field;
            set => this.namn2Field = value;
        }

        /// <remarks/>
        public decimal Prisinklmoms
        {
            get => this.prisinklmomsField;
            set => this.prisinklmomsField = value;
        }

        /// <remarks/>
        public decimal Volymiml
        {
            get => this.volymimlField;
            set => this.volymimlField = value;
        }

        /// <remarks/>
        public decimal PrisPerLiter
        {
            get => this.prisPerLiterField;
            set => this.prisPerLiterField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Saljstart
        {
            get => this.saljstartField;
            set => this.saljstartField = value;
        }

        /// <remarks/>
        public bool Utgått
        {
            get => this.utgåttField;
            set => this.utgåttField = value;
        }

        /// <remarks/>
        public string Varugrupp
        {
            get => this.varugruppField;
            set => this.varugruppField = value;
        }

        /// <remarks/>
        public string Typ
        {
            get => this.typField;
            set => this.typField = value;
        }

        /// <remarks/>
        public string Stil
        {
            get => this.stilField;
            set => this.stilField = value;
        }

        /// <remarks/>
        public string Forpackning
        {
            get => this.forpackningField;
            set => this.forpackningField = value;
        }

        /// <remarks/>
        public string Forslutning
        {
            get => this.forslutningField;
            set => this.forslutningField = value;
        }

        /// <remarks/>
        public string Ursprung
        {
            get => this.ursprungField;
            set => this.ursprungField = value;
        }

        /// <remarks/>
        public string Ursprunglandnamn
        {
            get => this.ursprunglandnamnField;
            set => this.ursprunglandnamnField = value;
        }

        /// <remarks/>
        public string Producent
        {
            get => this.producentField;
            set => this.producentField = value;
        }

        /// <remarks/>
        public string Leverantor
        {
            get => this.leverantorField;
            set => this.leverantorField = value;
        }

        /// <remarks/>
        public string Argang
        {
            get => this.argangField;
            set => this.argangField = value;
        }

        /// <remarks/>
        public string Provadargang
        {
            get => this.provadargangField;
            set => this.provadargangField = value;
        }

        /// <remarks/>
        public string Alkoholhalt
        {
            get => this.alkoholhaltField;
            set => this.alkoholhaltField = value;
        }

        /// <remarks/>
        public string Sortiment
        {
            get => this.sortimentField;
            set => this.sortimentField = value;
        }

        /// <remarks/>
        public string SortimentText
        {
            get => this.sortimentTextField;
            set => this.sortimentTextField = value;
        }

        /// <remarks/>
        public bool Ekologisk
        {
            get => this.ekologiskField;
            set => this.ekologiskField = value;
        }

        /// <remarks/>
        public bool Etiskt
        {
            get => this.etisktField;
            set => this.etisktField = value;
        }

        /// <remarks/>
        public bool Koscher
        {
            get => this.koscherField;
            set => this.koscherField = value;
        }

        /// <remarks/>
        public string RavarorBeskrivning
        {
            get => this.ravarorBeskrivningField;
            set => this.ravarorBeskrivningField = value;
        }
    }
}