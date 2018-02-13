using ITUniver.Calc.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebCalc.Models
{
    public class OperationModel
    {
        [Display(Name = "Операция")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Непонятно какую операцию выполнять!")]
        public string Operation { get; set; }

        [Display(Name = "Аргументы")]
        public double[] Args { get; set; }

        [Display(Name = "Результ")]
        [ReadOnly(true)]
        public double? Result { get; set; }

        public string[] AllOperations { get; set; }
    }
}