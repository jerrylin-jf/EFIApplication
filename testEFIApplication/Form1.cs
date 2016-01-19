using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace testEFIApplication
{
    public partial class Form1 : Form
    {
        public const int busWeight = 1048576;
        public const int deviceWeight = 32768;
        public const int functionWeight = 4096;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            uint registerDec = UInt32.Parse(txtRegister1.Text + txtRegister2.Text, System.Globalization.NumberStyles.HexNumber);
            uint busDec = UInt32.Parse(txtBus.Text, System.Globalization.NumberStyles.HexNumber);
            uint deviceDec = UInt32.Parse(txtDevice.Text, System.Globalization.NumberStyles.HexNumber);
            uint functionDec = UInt32.Parse(txtFunction.Text, System.Globalization.NumberStyles.HexNumber);
            uint offsetDec = UInt32.Parse(txtOffset.Text, System.Globalization.NumberStyles.HexNumber);

            uint addressDec = (busDec * busWeight) + (deviceDec * deviceWeight) + (functionDec * functionWeight) + offsetDec + registerDec;
            string addressHex = Convert.ToString(addressDec, 16);

            txtResult.Text = addressHex;

            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            excelApp.Workbooks.Add();
            Excel.Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
            workSheet.Cells[1, "A"] = registerDec;
            workSheet.Cells[2, "A"] = busDec;
            workSheet.Cells[3, "A"] = deviceDec;
            workSheet.Cells[4, "A"] = functionDec;
            workSheet.Cells[5, "A"] = offsetDec;
            workSheet.Cells[6, "A"] = addressDec;
            workSheet.Cells[7, "A"] = addressHex;
        }
    }
}
