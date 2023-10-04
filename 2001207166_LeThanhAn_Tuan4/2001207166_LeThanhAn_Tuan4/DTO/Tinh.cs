using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Tinh
    {
        public class TinhToan
        {
            public float _a, _b;

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
            public TinhToan()
            {
                _a = _b = 0;
            }
            public TinhToan(float _a, float _b)
            {
                _a = a;
                _b = b;
            }
            public float Cong()
            {
                return _a + _b;
            }
            public float Tru()
            {
                return _a - _b;
            }
            public float Nhan()
            {
                return _a * _b;
            }
            public float Chia()
            {
                return _a / _b;
            }
        }
    }
}
