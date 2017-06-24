using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploAPIDapper.Model
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
    }
}
