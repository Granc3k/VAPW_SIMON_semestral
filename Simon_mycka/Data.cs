namespace Simon_mycka
{
    public class Data
    {
        public bool VstupVrata { get; private set; }    //jeslti jsou otevřená
        public bool VystupVrata { get; private set; }  //jestli jsou otevřená
        public Semafor VstupSemafor { get; private set; }
        public Semafor VystupSemafor { get; private set; }

        public bool picture1 { get; private set; }

        public bool picture2 { get; private set; }

        public bool picture3 { get; private set; }

        public Data(bool _VstupVrata, bool _VystupVrata, Semafor _VstupSemafor, Semafor _VystupSemafor, bool _picture1, bool _picture2, bool _picture3)
        {
            VstupVrata = _VstupVrata;
            VystupVrata = _VystupVrata;
            VstupSemafor = _VstupSemafor;
            VystupSemafor = _VystupSemafor;
            picture1 = _picture1;
            picture2 = _picture2;
            picture3 = _picture3;
        }
    }
}
