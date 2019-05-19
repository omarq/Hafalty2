using System;
using Haflaty.Common;

namespace Haflaty.Infrastructure
{
    public class MachineDateTime : IDateTime
    {

        public DateTime Now => DateTime.Now;

        public int CurrentYear => DateTime.Now.Year;
    }
}
