using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1NUnit
{
    public class xuLyTinhToan
    {
        public int TinhTongHaiSo(int a, int b)
        {
            return a + b;
        }
        public bool isNumber(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Chuỗi đầu vào là null hoặc rỗng.");
                return false;
            }

            try
            {
                int temp = Int32.Parse(str);
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Chuỗi đầu vào không đúng định dạng.");
                return false;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Chuỗi đầu vào đại diện cho một số nhỏ hơn MinValue hoặc lớn hơn MaxValue.");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi không mong muốn: {ex.Message}");
                return false;
            }
        }
    }
}
