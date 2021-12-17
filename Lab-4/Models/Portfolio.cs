using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_4.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string CardTitle { get; set; }
        public string Title { get; set; }
        public string Client { get; set; }
        public string ProjectUrl { get; set; }
        public DateTime ProjectDate { get; set; }
        public Category Category { get; set; }

        public List<PortfolioSlider> PortfolioSliders { get; set; }


    }
}
