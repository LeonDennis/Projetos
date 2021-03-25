using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExChart
{
    class BDVendasBLL
    {
        public static void conecta()
        {
            BDVendasDAL.conecta();
            if (!Erro.getErro())
            {
                BDVendasDAL.populaDR();
            }
        }

        public static void desconecta()
        {
            BDVendasDAL.desconecta();
        }

        public static void getProximo()
        {
            BDVendasDAL.getProximo();
        }

        private static int BDX;
        private static int BDY;
        public static void setBDX(int _BDX) { BDX = _BDX; }
        public static void setBDY(int _BDY) { BDY = _BDY; }
        public static int getBDX() { return BDX; }
        public static int getBDY() { return BDY; }
    }
}
