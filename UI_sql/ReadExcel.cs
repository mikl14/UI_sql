using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Cells;

namespace UI_sql
{
    class ReadExcel
    {
        Workbook workbook;
        int list;

        public void OpenFile(string path)
        {

            workbook = new Workbook(path);
        }
        public int GetListCount()
        {
            return workbook.Worksheets.Count();
        }
        public String[] Get_Col_names(int list)
        {
            this.list = list;

            List<String> names = new List<string>();

            // Получаем первый лист
            Worksheet worksheet = workbook.Worksheets[list];

            // Получаем диапазон ячеек, содержащих данные
            Aspose.Cells.Range range = worksheet.Cells.MaxDisplayRange;

            // Выводим данные в консоль
           // worksheet.Cells.UnMerge(range.FirstRow, range.FirstColumn,range.RowCount, range.ColumnCount);
            for (int col = range.FirstColumn; col < range.ColumnCount; col++)
            {
                if (worksheet.Cells[7, col].Value != null)
                {
                    names.Add(worksheet.Cells[7, col].Value.ToString());
                }
            }
            return names.ToArray();
        }

        public String[] Get_Val_In_Cols(string col_name)
        {
            List<String> names = new List<string>();
            Worksheet worksheet = workbook.Worksheets[list];

            // Получаем диапазон ячеек, содержащих данные
            Aspose.Cells.Range range = worksheet.Cells.MaxDisplayRange;

            int col = FindColByValue(col_name);
            for (int row = 7; row < range.RowCount; row++)
            {

                    if(worksheet.Cells[row, col].Value != null)
                    {
                        names.Add(worksheet.Cells[row, col].Value.ToString());
                    }
 

            }
            return names.ToArray();
        }

        int FindColByValue(string name)
        {
            Worksheet worksheet = workbook.Worksheets[list];

            // Получаем диапазон ячеек, содержащих данные
            Aspose.Cells.Range range = worksheet.Cells.MaxDisplayRange;

            // Выводим данные в консоль
            // worksheet.Cells.UnMerge(range.FirstRow, range.FirstColumn,range.RowCount, range.ColumnCount);
            for (int col = range.FirstColumn; col < range.ColumnCount; col++)
            {
                if (worksheet.Cells[7, col].Value != null)
                {
                    if (worksheet.Cells[7, col].Value.ToString() == name)
                    {
                        return col;
                    }
                }
               

            }
            return -1;
        }
    }
}
