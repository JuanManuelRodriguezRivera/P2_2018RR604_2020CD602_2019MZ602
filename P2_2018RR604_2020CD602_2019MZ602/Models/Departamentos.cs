﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace P2_2018RR604_2020CD602_2019MZ602.Models
{
    public class Departamentos
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
       
    }
}
