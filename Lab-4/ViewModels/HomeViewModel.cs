using Lab_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_4.ViewModels
{
    public class HomeViewModel
    {
        public List<Client> Clients { get; set; }
        public List<Services> Services { get; set; }
        public List<Category> Categories { get; set; }
        public List<PortfolioSlider> PortfolioSliders { get; set; }
        public List<Portfolio> Portfolios { get; set; }

    }
}
