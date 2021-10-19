using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Project
{
    public class Visitor
    {
        public int VisitorAge;
        public double VisitorMoney;

        public Visitor(int visitorAge)
        {
            VisitorAge = visitorAge;
            VisitorMoney = new Random().Next();
        }
    }
}