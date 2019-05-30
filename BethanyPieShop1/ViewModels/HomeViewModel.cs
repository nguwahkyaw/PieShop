using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanyPieShop1.Models;

namespace BethanyPieShop1.ViewModels
{
    public class HomeViewModel
    {
        public String Title { get; set; }
        public List<Pie> Pies { get; set; }

    }
}
