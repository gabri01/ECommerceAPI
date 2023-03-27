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
        public Ordine()
        {
            Ordiniprodottis = new HashSet<Ordiniprodotti>();
        }

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
        public int IDCorriere { get; set; }
        [Required]
        [StringLength(50)]
        public string IndirizzoSpedizione { get; set; }
        public int IdPagamento { get; set; }

        [ForeignKey("IDCorriere")]
        [InverseProperty("Ordines")]
        public virtual Corriere IDCorriereNavigation { get; set; }
        [ForeignKey("IDUtente")]
        [InverseProperty("Ordines")]
        public virtual Utente IDUtenteNavigation { get; set; }
        [ForeignKey("IdPagamento")]
        [InverseProperty("Ordines")]
        public virtual Pagamento IdPagamentoNavigation { get; set; }
        [InverseProperty("IDOrdineNavigation")]
        public virtual ICollection<Ordiniprodotti> Ordiniprodottis { get; set; }
    }
}