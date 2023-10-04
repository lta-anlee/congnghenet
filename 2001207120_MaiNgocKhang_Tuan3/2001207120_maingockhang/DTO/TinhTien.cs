using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TinhTien
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
            _a = _b = 0;
        }

        public TinhTien(float a, float b)
        {
            _a = a;
            _b = b;
        }

        public float cong()
        {
            return _a + _b;
        }
        public float tru()
        {
            return _a - _b;
        }
        public float chia()
        {
            return _a / _b;
        }
        public float nhan()
        {
            return _a * _b;
        }
    }
}
