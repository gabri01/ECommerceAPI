﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models
{
    [Table("Pagamento")]
    public partial class Pagamento
    {
        public Pagamento()
        {
            Ordines = new HashSet<Ordine>();
        }

        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [InverseProperty("IDPagamentoNavigation")]
        public virtual ICollection<Ordine> Ordines { get; set; }
    }
}