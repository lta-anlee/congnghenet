using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTien
{
    public class Class1
    {
        float _a, _b;

        public float b
        {
            get { return _b; }
            set { _b = value; }
        }

        public float a
        {
            get { return _a; }
            set { _a = value; }
        }

        public TinhTien()
        {
            _a=_b=0;
        }
    }
}
