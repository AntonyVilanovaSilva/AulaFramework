//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AulaFramework.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MOVIMENTACAO
    {
        public int ID_MOVI { get; set; }
        public int ID_PRO { get; set; }
        public int ID_SEC { get; set; }
        public Nullable<int> ID_REQ { get; set; }
        public Nullable<int> ID_NOTA { get; set; }
        public Nullable<decimal> PRE_UNIT { get; set; }
        public Nullable<decimal> QTD_PRO { get; set; }
        public Nullable<decimal> SALDO { get; set; }
        public Nullable<decimal> EST_ANT { get; set; }
        public bool TIPO_MOV { get; set; }
        public Nullable<int> MES_MOV { get; set; }
        public int ANO_MOV { get; set; }
        public System.DateTime DATA_MOV { get; set; }
        public Nullable<int> ID_SET { get; set; }
    }
}
