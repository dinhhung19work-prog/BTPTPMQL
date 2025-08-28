using Microsoft.AspNetCore.Mvc;

namespace btth28.Controllers
{
    public class Bai3Controller : Controller
    {
        [HttpGet]
        public IActionResult Bai3()
        {
            return View();
        }

        [HttpPost]
      public IActionResult Bai3([FromForm] float chieuCao, [FromForm] float canNang)
        {
            string ketQua = "";
            if (chieuCao <= 0 || canNang <= 0)
            {
                ketQua = "Chiều cao và cân nặng phải lớn hơn 0.";
            }
            else
            {
                float bmi = canNang / (chieuCao * chieuCao);
                ketQua = $"Chỉ số BMI của bạn là: {bmi:F2}. ";

                // Phân loại BMI theo chuẩn WHO
                if (bmi < 18.5)
                    ketQua += "Bạn đang thiếu cân.";
                else if (bmi < 24.9)
                    ketQua += "Bạn có cân nặng bình thường.";
                else if (bmi < 29.9)
                    ketQua += "Bạn bị thừa cân.";
                else
                    ketQua += "Bạn bị béo phì.";
            }

            ViewBag.Bai3 = ketQua;
            return View();
        }
    }
}
