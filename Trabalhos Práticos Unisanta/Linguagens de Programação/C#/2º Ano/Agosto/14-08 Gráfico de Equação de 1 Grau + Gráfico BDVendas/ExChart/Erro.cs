﻿using System;

namespace ExChart
{
    class Erro
    {
        private static String msg;
        private static bool erro;

        public static void setMsg(String _msg)
        {
            erro = true;
            msg = _msg;
        }
        public static void setErro(bool _erro) { erro = _erro; }
        public static String getMsg() { return msg; }
        public static bool getErro() { return erro; }
    }
}
