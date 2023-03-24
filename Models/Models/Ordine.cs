﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models
{
    [Table("Ordine")]
    public partial class Ordine
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(20)]
        public string Stato { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Data { get; set; }
        [StringLength(250)]
        public string Commento { get; set; }
        public int IDUtente { get; set; }
        public int IDPagamento { get; set; }
        public int IDCorriere { get; set; }
        public int IDProdotto { get; set; }
        [Required]
        [StringLength(50)]
        public string IndirizzoSpedizione { get; set; }

        [ForeignKey("IDCorriere")]
        [InverseProperty("Ordines")]
        public virtual Corriere IDCorriereNavigation { get; set; }
        [ForeignKey("IDPagamento")]
        [InverseProperty("Ordines")]
        public virtual Pagamento IDPagamentoNavigation { get; set; }
        [ForeignKey("IDProdotto")]
        [InverseProperty("Ordines")]
        public virtual Prodotto IDProdottoNavigation { get; set; }
        [ForeignKey("IDUtente")]
        [InverseProperty("Ordines")]
        public virtual Utente IDUtenteNavigation { get; set; }
    }
}