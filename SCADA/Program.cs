using BTL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using S7.Net.Types;

namespace SCADA
{
    public class ThongTin       //Lưu thông tin cài đặt hệ thống
    {
        static public int SoSilo = 15;
        static public string soHieuCt;
        static public float KL_Them, KL_Me;
        static public int TongSoMe;
        static public float TgTron, TgXaTron;
        static public string TgTreCanNL = "1.5", TgTreCanF = "2.45";
        static public string TgTreFNghien = "1.2", TgTreNghienH = "2.6", TgTreHTron = "1.3", TgBomDau = "5.5";
        static public string DiaChiIP;
        static public bool checkKetNoi;
        static public Plc plc;
        static public bool checkTestIO;
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_DangNhap());
        }
    }
}
