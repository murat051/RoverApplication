namespace RoverApp
{
    public class YonlerinKontrolleri
    {
        public void GuncelYonN(char talimat, ref string yon, ref string GuncelYonum)
        {
            if (talimat == 'L') // talimat Left ise;
            {
                GuncelYonum = "W"; // Güncel yönü West yap.
                yon = "W"; // yönü West yap.
            }
            else if (talimat == 'R')  // talimat Right ise;
            {
                GuncelYonum = "E"; // Güncel yönü East yap.
                yon = "E"; // yönü East yap.
            }
        }

        public void GuncelYonW(char talimat, ref string yon, ref string GuncelYonum)
        {
            if (talimat == 'L')
            {
                GuncelYonum = "S";
                yon = "S";
            }
            else if (talimat == 'R')
            {
                GuncelYonum = "N";
                yon = "N";
            }
        }

        public void GuncelYonS(char talimat, ref string yon, ref string GuncelYonum)
        {
            if (talimat == 'L')
            {
                GuncelYonum = "E";
                yon = "E";
            }
            else if (talimat == 'R')
            {
                GuncelYonum = "W";
                yon = "W";
            }
        }

        public void GuncelYonE(char talimat, ref string yon, ref string GuncelYonum)
        {
            if (talimat == 'L')
            {
                GuncelYonum = "N";
                yon = "N";
            }
            else if (talimat == 'R')
            {
                GuncelYonum = "S";
                yon = "S";
            }
        }
    }
}
