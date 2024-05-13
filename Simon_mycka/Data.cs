namespace Simon_mycka
{
    public class Data
    {
        public bool VstupVrata { get; private set; }    //jeslti jsou otevřená
        public bool VystupVrata { get; private set; }  //jestli jsou otevřená
        public Semafor VstupSemafor { get; private set; }
        public Semafor VystupSemafor { get; private set; }

        public Data(bool vstupVrata, bool vystupVrata, Semafor vstupS, Semafor vystupS)
        {
            VstupVrata = vstupVrata;
            VystupVrata = vystupVrata;
            VstupSemafor = vstupS;
            VystupSemafor = vystupS;
        }
    }
}
