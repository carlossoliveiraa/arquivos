using System;
using FileHelpers;

namespace ArquivosPosicionados
{

    [FixedLengthRecord(FixedMode.ExactLength)]
    public class NovosCotistasDTO
    {
        [FieldFixedLength(5)]
        //[FieldAlign(AlignMode.Right)]
        public string agencia;

        [FieldFixedLength(13)]
        public string conta;

        [FieldFixedLength(10)]
        [FieldConverter(ConverterKind.Date, "ddMMyyyy")] 
        public DateTime dataInclusao;

        [FieldFixedLength(1)]
        public string tipo;

        [FieldFixedLength(7)]
        public string idUsuario;

        [FieldFixedLength(14)]
        public string cnpj;
    }
}
