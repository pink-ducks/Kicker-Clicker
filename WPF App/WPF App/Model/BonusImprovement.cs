using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_App.Model
{
    public abstract class BonusImprovement: Improvement
    {
        // METHODS 
        public override void Upgrade()
        {
            throw new NotImplementedException();
        }
    }
}
