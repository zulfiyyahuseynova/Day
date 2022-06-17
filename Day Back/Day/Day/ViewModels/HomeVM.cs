using Day.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day.ViewModels
{
    public class HomeVM
    {
        public List<App> Apps { get; set; }
        public List<Card> Cards { get; set; }
        public List<Web> Webs { get; set; }
    }
}
