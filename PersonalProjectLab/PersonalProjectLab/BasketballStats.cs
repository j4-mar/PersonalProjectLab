using System;
namespace PersonalProjectLab
{
    public class BasketballStats
    {
        public BasketballStats()
        {

        }
        public decimal CalculateShootingPercentage(int shotsMade, int shotsAtt)
        {
            decimal avg = 0.00m;
            int ShotPtg;
            ShotPtg = shotsMade / shotsAtt;
            return avg;
        }

        public decimal Calculate3Point(int threeMade, int threeAtt)
        {
            decimal avg = 0.00m;
            avg = threeMade / threeAtt;
            return avg;
        }

        public decimal CalculateEFG(int shotsMade, int threeMade, int shotsAtt)
        {
            decimal avg = 0.00m;
            avg = (decimal)(shotsMade + (0.5 * threeMade)) / shotsAtt;
            return avg;
        }




    }
}

