﻿using System;

namespace WallegNFe.Consulta
{
    public class CartaCorrecao
    {
        public String NumeroLote { get; set; }
        public String CodigoUF { get; set; }
        public String CNPJ { get; set; }
        public String NotaChaveAcesso { get; set; }
        public String Correcao { get; set; }
        public DateTime DataEvento { get; set; }
    }
}