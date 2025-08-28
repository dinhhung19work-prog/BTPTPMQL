using Microsoft.AspNetCore.Mvc;

namespace btth28.Controllers
{
    public class Bai2Controller : Controller
    {
        [HttpGet]
        public IActionResult Bai2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Bai2(float num1, float num2, string phepTinh)
        {
            float ketQua = 0;
            string thongBao = "";

            switch (phepTinh)
            {
                case "cong":
                    ketQua = num1 + num2;
                    thongBao = $"Kết quả phép cộng: {ketQua}";
                    break;

                case "tru":
                    ketQua = num1 - num2;
                    thongBao = $"Kết quả phép trừ: {ketQua}";
                    break;

                case "nhan":
                    ketQua = num1 * num2;
                    thongBao = $"Kết quả phép nhân: {ketQua}";
                    break;

                case "chia":
                    if (num2 != 0)
                    {
                        ketQua = num1 / num2;
                        thongBao = $"Kết quả phép chia: {ketQua}";
                    }
                    else
                    {
                        thongBao = "Không thể chia cho 0.";
                    }
                    break;

                default:
                    thongBao = "Phép tính không hợp lệ.";
                    break;
            }

            ViewBag.KetQua = thongBao;
            return View();
        }
    }
}
