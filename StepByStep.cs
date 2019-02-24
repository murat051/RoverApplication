namespace RoverApp
{
    public class StepByStep
    {
        public void Step(ref string ilkYonum, char talimat, ref int X, ref int Y, ref string GuncelYonum)
        {
            if (ilkYonum == "N" || ilkYonum == "W" || ilkYonum == "S" || ilkYonum == "E") // ilk yönüm doğru girildiyse;
            {
                string yon = GuncelYonum; // yönümü güncelle.
                YonlerinKontrolleri nesne2 = new YonlerinKontrolleri();

                if (GuncelYonum == "N") // güncel yönüm N ise;
                    nesne2.GuncelYonN(talimat, ref yon, ref GuncelYonum); // GuncelYonN methoduna git.

                else if (GuncelYonum == "W") // güncel yönüm W ise;
                    nesne2.GuncelYonW(talimat, ref yon, ref GuncelYonum); // GuncelYonW methoduna git.

                else if (GuncelYonum == "S") // güncel yönüm S ise;
                    nesne2.GuncelYonS(talimat, ref yon, ref GuncelYonum); // GuncelYonS methoduna git.

                else  // güncel yönüm E ise;
                    nesne2.GuncelYonE(talimat, ref yon, ref GuncelYonum); // GuncelYonE methoduna git.

                if (talimat == 'M') // talimat M ise;
                {
                    if (yon == "E") // ve East e bakıyorsam;
                        X++; // X koordinatını 1 arttır.

                    else if (yon == "W") // ve West e bakıyorsam;
                        X--; // X koordinatını 1 azalt.

                    else if (yon == "N") // ve North a bakıyorsam;
                        Y++; // Y koordinatını 1 arttır.

                    else if (yon == "S") // ve South a bakıyorsam;
                        Y--; // Y koordinatını 1 azalt.
                }
            }
        }
    }
}

