using FejlesztesiMintak.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FejlesztesiMintak.Entities
{
    public class BallFactory : IToyFactory
    {
        public Abstractions.Toy CreateNew()
        {
            return new Ball();
        }
    }
}
