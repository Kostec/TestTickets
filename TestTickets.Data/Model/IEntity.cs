﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTickets.Data.Model
{
    public abstract class IEntity
    {
        [Key, Column(Order = 0)]
        public int Id { get; set; }
    }
}
