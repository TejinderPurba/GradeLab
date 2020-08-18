using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.WinForms;

namespace GradeTrackerV3
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            /*
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0, 10),
                        new ObservablePoint(5, 20),
                        new ObservablePoint(10, 30),
                        new ObservablePoint(15, 15),
                        new ObservablePoint(20, 60),
                        new ObservablePoint(25, 40),

                        // Could add a loop here

                    },
                    PointGeometrySize = 5
                }
            };*/


            // Populating the grade table on the dashboard
            int n = dataGridViewGrades.Rows.Add();
            dataGridViewGrades.Rows[n].Cells[0].Value = "Testwudhwiudhwuidh";
            dataGridViewGrades.Rows[n].Cells[1].Value = "Test";
            dataGridViewGrades.Rows[n].Cells[2].Value = "Test";
            dataGridViewGrades.Rows[n].Cells[3].Value = "Test";
            n = dataGridViewGrades.Rows.Add();
            dataGridViewGrades.Rows[n].Cells[0].Value = "Test";
            dataGridViewGrades.Rows[n].Cells[1].Value = "Test";
            dataGridViewGrades.Rows[n].Cells[2].Value = "Test";
            dataGridViewGrades.Rows[n].Cells[3].Value = "Test";
            n = dataGridViewGrades.Rows.Add();
            dataGridViewGrades.Rows[n].Cells[0].Value = "Test";
            dataGridViewGrades.Rows[n].Cells[1].Value = "Test";
            dataGridViewGrades.Rows[n].Cells[2].Value = "Test";
            dataGridViewGrades.Rows[n].Cells[3].Value = "Test";
            n = dataGridViewGrades.Rows.Add();
            dataGridViewGrades.Rows[n].Cells[0].Value = "Test";
            dataGridViewGrades.Rows[n].Cells[1].Value = "Test";
            dataGridViewGrades.Rows[n].Cells[2].Value = "Test";
            dataGridViewGrades.Rows[n].Cells[3].Value = "Test";

        }
    }
}
