using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calendar
{
    public partial class CalendarForm : Form
    {
        private Dictionary<string, int> numberWeekDays = new Dictionary<string, int> {
            { "Monday", 0 },
            { "Tuesday", 1 },
            { "Wednesday", 2 },
            { "Thursday", 3 },
            { "Friday", 4 },
            { "Saturday", 5 },
            { "Sunday", 6 },
        };

        enum CellDimensions
        {
            X = 110,
            Y = 27
        }

        private int totalSizePercentage = 100;
        private int numberOfDaysOfWeek = 7;
        private DateTime selectedDate;
        private int numberOfDaysBetweenMondayAndFirstDayOfMonth;
        private int numberOfDaysOfMonth;
        private int defaultSelectedListBoxIndex = -1;
        private int[] weekendColumnIndices = { 5, 6 };
        private int defaultDayOfMonth = 1;
        private int gapBetweenIndexAndNumber = 1;
        private int fontSizeOfNumbers = 20;

        public CalendarForm()
        {
            InitializeComponent();
            selectedDate = DateTime.Today;
            updateCalendar();
        }

        private void updateCalendar()
        {
            bool isCurrentMonth;
            if (selectedDate.Month == DateTime.Today.Month)
            {
                isCurrentMonth = true;
            }
            else
            {
                isCurrentMonth = false;
            }
            monthLabel.Text = getMonthAsWord(selectedDate);
            calendarTable.ColumnCount = numberOfDaysOfWeek;
            int numberOfRows = getNumberOfRows(selectedDate);
            calendarTable.RowCount = numberOfRows;
            float sizePercentageOfEachRow = totalSizePercentage / numberOfRows;
            calendarTable.Controls.Clear();
            calendarTable.RowStyles.Clear();

            bool isFirstRow;
            int dayNumber = 1;
            int cellNumberFromLeft;
            bool shouldBeWrittenOnCell;

            for (int rowIndex = 0; rowIndex < numberOfRows; rowIndex++)
            {
                calendarTable.RowStyles.Add(new RowStyle(SizeType.Percent, sizePercentageOfEachRow));
            }

            for (int rowIndex = 0; rowIndex < numberOfRows; rowIndex++)
            {
                if (rowIndex == 0)
                {
                    isFirstRow = true;
                    cellNumberFromLeft = numberOfDaysBetweenMondayAndFirstDayOfMonth;
                }
                else
                {
                    isFirstRow = false;
                    cellNumberFromLeft = 1;
                }

                for (int columnIndex = 0; columnIndex < numberOfDaysOfWeek; columnIndex++)
                {

                    if (!(isFirstRow && columnIndex < numberOfDaysBetweenMondayAndFirstDayOfMonth) && dayNumber <= numberOfDaysOfMonth)
                    {
                        shouldBeWrittenOnCell = true;
                    }
                    else
                    {
                        shouldBeWrittenOnCell = false;
                    }

                    Label newLabel = createLabel(cellNumberFromLeft, dayNumber, shouldBeWrittenOnCell, isCurrentMonth);
                    calendarTable.Controls.Add(newLabel);
                    cellNumberFromLeft++;
                    if (shouldBeWrittenOnCell)
                    {
                        dayNumber++;
                    }
                }
            }
        }

        private Label createLabel(int cellNumberFromLeft, int dayNumber, bool shouldBeWrittenOnCell, bool isCurrentMonth)
        {
            Label newLabel = new Label();
            if (shouldBeWrittenOnCell)
            {
                newLabel.Text = dayNumber.ToString();
                if (isCurrentMonth && dayNumber == DateTime.Today.Day)
                {
                    newLabel.BackColor = Color.LightGreen;
                }
                else
                {
                    newLabel.BackColor = Color.Transparent;
                }
            }

            newLabel.Location = new Point((int)CellDimensions.X * cellNumberFromLeft + calendarTable.Location.X, (int)CellDimensions.Y * cellNumberFromLeft + calendarTable.Location.Y);
            newLabel.Dock = DockStyle.Fill;
            newLabel.TextAlign = ContentAlignment.MiddleCenter;
            newLabel.Font = new Font("Microsoft Sans Serif", fontSizeOfNumbers);
            return newLabel;
        }

        private int getNumberOfRows(DateTime date)
        {
            DateTime firstDayOfMonth = new DateTime(date.Year, date.Month, defaultDayOfMonth);
            numberOfDaysOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1).Day;
            numberOfDaysBetweenMondayAndFirstDayOfMonth = numberWeekDays[getDayOfWeekAsWord(firstDayOfMonth)];
            return (int)Math.Ceiling((numberOfDaysOfMonth + numberOfDaysBetweenMondayAndFirstDayOfMonth) / (float)numberOfDaysOfWeek);
        }

        private void CalendarTable_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (weekendColumnIndices.Contains(e.Column))
            {
                e.Graphics.FillRectangle(Brushes.LightCyan, e.CellBounds);
            }
        }

        private string getDayOfWeekAsWord(DateTime date)
        {
            return date.ToString("dddd", new CultureInfo("en-EN"));
        }

        private string getMonthAsWord(DateTime date)
        {
            return date.ToString("MMMM   yyyy", new CultureInfo("en-EN"));
        }

        private void NextMonthButton_Click(object sender, EventArgs e)
        {
            selectedDate = selectedDate.AddMonths(1);
            updateCalendar();
        }

        private void PreviousMonthButton_Click(object sender, EventArgs e)
        {
            selectedDate = selectedDate.AddMonths(-1);
            updateCalendar();
        }

        private void TodayButton_Click(object sender, EventArgs e)
        {
            if (selectedDate.Month != DateTime.Today.Month)
            {
                selectedDate = DateTime.Today;
                updateCalendar();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (MonthListBox.SelectedIndex != defaultSelectedListBoxIndex && YearListBox.SelectedIndex != defaultSelectedListBoxIndex)
            {
                selectedDate = new DateTime(Int32.Parse(YearListBox.SelectedItem.ToString()), MonthListBox.SelectedIndex + gapBetweenIndexAndNumber, defaultDayOfMonth);
                updateCalendar();
            }
            else
            {
                MessageBox.Show("You must select a month and a year");
            }
        }
    }
}
