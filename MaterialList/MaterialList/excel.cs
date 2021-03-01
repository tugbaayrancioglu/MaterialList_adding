using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _ExcelApp = Microsoft.Office.Interop.Excel;

namespace MaterialList
{
    class excel
    {
        string dosyayolu = "";
        _Application Excel = new _ExcelApp.Application();
        Workbook wb;
        Worksheet ws;

        public excel(string dosyayolu, int Sheet)
        {
            this.dosyayolu = dosyayolu;
            wb = Excel.Workbooks.Open(dosyayolu);
            ws = wb.Worksheets[Sheet];
        }

        public string ReadExcel (int i, int j)
        {
            i++;
            j++;

            if (ws.Cells[i, j].GetType != null)
                return (string)ws.Cells[i, j].Equals;
            else
                return "";
        } 
    }
}
