using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo1NUnit;
using NUnit.Framework;
namespace Test
{
    //[TestFixture] là một thuộc tính được áp dụng cho một lớp để chỉ định rằng lớp đó chứa các phương thức kiểm thử đơn vị.
    //[SetUp] được sử dụng để thiết lập trạng thái ban đầu hoặc khởi tạo các đối tượng cần thiết cho các kiểm thử.
    //[Test] là một thuộc tính được áp dụng cho một phương thức để chỉ định rằng phương thức đTestFixture] 
    [TestFixture]
    public class xuLyTest
    {
        private xuLyTinhToan _xuLyTinhToan;

        [SetUp]
        public void SetUp()
        {
            _xuLyTinhToan = new xuLyTinhToan();
        }

        [Test]
        public void TinhTongHaiSo_ValidInputs_ReturnsCorrectSum()
        {
            int result = _xuLyTinhToan.TinhTongHaiSo(3, 5);
            Assert.AreEqual(8, result); // so sánh kết quả 
        }

        [Test]
        [TestCase("123", true)]
        [TestCase("abc", false)]
        [TestCase("", false)]
        [TestCase(null, false)]
        [TestCase("123.45", false)]
        [TestCase("2147483647", true)] // Giá trị int tối đa
        [TestCase("-2147483648", true)] // Giá trị int tối thiểu
        public void isNumber_TestCases(string input, bool expectedResult)
        {
            bool result = _xuLyTinhToan.isNumber(input);
            Assert.AreEqual(expectedResult, result);
        }
    
}
}
