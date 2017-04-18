using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice
{
    public interface IVolumeCalculator
    {
        double CalculateVolume(IList<IVolume> shapes);
    }
}
