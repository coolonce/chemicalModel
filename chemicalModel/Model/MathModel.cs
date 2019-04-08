using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chemicalModel
{
    class MathModel
    {
        //Температура материала в канале
        private double Yhat = 0.0;
        //Скорость крышки 
        private double speedHat = 0.0;
        //Коэффициент геометрической формы канала
        private double F = 0.0;


        public double GetIndexesQuality() => 1.0;

        /*
         * Расчет Гаммы (Скорость деформации сдвига)
         */
        private double CalcYhat(double speedHat, double H)
        {
            return speedHat / H;
        }
        /*
         * Рассчет коэффициента геометрической формы канала
         */
        public double CaclF(double H, double W)
        {
            return 0.125 * (H / W) * (H / W) - 0.625 * (H / W) + 1;
        }


        private double CalcRo() {
            return 0;
        }
        
        /*
         * Объемный  расход потока материала в канале
         */
        private double CalcQ(double H, double W, double speedHat)
        {
            return ((W*H*speedHat)/2)*CaclF(H,W);
        }
        //Температура материала в канале
        //темп приведения, темп коэф вязкости мат, часть канала
        private double CalcT(double tempPriv, double b, double l)
        {
            return tempPriv + (1/b) * Math.Log(k(l));
        }
        private double k(double l)
        {
            return 0;
        }

        private double qy()
        {
            return 0;
        }
        private double qalpha()
        {

            return 0;
        }

        private double CalcG(double ro, double H, double W, double speedHat)
        {
            return 3600 * ro * CalcQ(H, W, speedHat);
        }
    }
}
