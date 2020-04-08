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
        private Dictionary<string, int> weekDays = new Dictionary<string, int> {
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

        private const int TotalSizePercentage = 100;
        private const int DaysOfWeek = 7;
        private const int InitialDayOfMonth = 1;
        private const int GapBetweenIndexAndNumber = 1;
        private const int DefaultSelectedListBoxIndex = -1;
        private const int FontSizeOfNumbers = 20;
        private const int FirstRowAndColumnIndex = 0;
        private const int NextTimeInterval = 1;
        private const int PreviousTimeInterval = -1;

        private const string ErrorMessage = "You must select a month and a year";
        private const string LetterFont = "Microsoft Sans Serif";
        private const string EnglishLanguageCode = "en-EN";
        private const string DayFormat = "dddd";
        private const string MonthAndYearFormat = "MMMM   yyyy";

        private DateTime selectedDate;
        private int daysBetweenMondayAndFirstDayOfMonth;
        private int daysOfMonth;
        private int[] weekendColumnIndices = { 5, 6 };

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
            calendarTable.ColumnCount = DaysOfWeek;
            int numberOfRows = getNumberOfRows(selectedDate);
            calendarTable.RowCount = numberOfRows;
            float sizePercentageOfEachRow = TotalSizePercentage / numberOfRows;
            calendarTable.Controls.Clear();
            calendarTable.RowStyles.Clear();

            bool isFirstRow;
            int day = InitialDayOfMonth;
            int cellNumberFromLeft;
            bool shouldBeWrittenOnCell;

            for (int rowIndex = FirstRowAndColumnIndex; rowIndex < numberOfRows; rowIndex++)
            {
                calendarTable.RowStyles.Add(new RowStyle(SizeType.Percent, sizePercentageOfEachRow));
            }

            for (int rowIndex = FirstRowAndColumnIndex; rowIndex < numberOfRows; rowIndex++)
            {
                if (rowIndex == FirstRowAndColumnIndex)
                {
                    isFirstRow = true;
                    cellNumberFromLeft = daysBetweenMondayAndFirstDayOfMonth;
                }
                else
                {
                    isFirstRow = false;
                    cellNumberFromLeft = GapBetweenIndexAndNumber;
                }

                for (int columnIndex = FirstRowAndColumnIndex; columnIndex < DaysOfWeek; columnIndex++)
                {

                    if (!(isFirstRow && columnIndex < daysBetweenMondayAndFirstDayOfMonth) && day <= daysOfMonth)
                    {
                        shouldBeWrittenOnCell = true;
                    }
                    else
                    {
                        shouldBeWrittenOnCell = false;
                    }

                    Label newLabel = createLabel(cellNumberFromLeft, day, shouldBeWrittenOnCell, isCurrentMonth);
                    calendarTable.Controls.Add(newLabel);
                    cellNumberFromLeft++;
                    if (shouldBeWrittenOnCell)
                    {
                        day++;
                    }
                }
            }
        }

        private Label createLabel(int cellNumberFromLeft, int day, bool shouldBeWrittenOnCell, bool isCurrentMonth)
        {
            Label newLabel = new Label();
            if (shouldBeWrittenOnCell)
            {
                newLabel.Text = day.ToString();
                if (isCurrentMonth && day == DateTime.Today.Day)
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
            newLabel.Font = new Font(LetterFont, FontSizeOfNumbers);
            return newLabel;
        }

        private int getNumberOfRows(DateTime date)
        {
            DateTime firstDayOfMonth = new DateTime(date.Year, date.Month, InitialDayOfMonth);
            daysOfMonth = firstDayOfMonth.AddMonths(NextTimeInterval).AddDays(PreviousTimeInterval).Day;
            daysBetweenMondayAndFirstDayOfMonth = weekDays[getDayOfWeekAsWord(firstDayOfMonth)];
            return (int)Math.Ceiling((daysOfMonth + daysBetweenMondayAndFirstDayOfMonth) / (float)DaysOfWeek);
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
            return date.ToString(DayFormat, new CultureInfo(EnglishLanguageCode));
        }

        private string getMonthAsWord(DateTime date)
        {
            return date.ToString(MonthAndYearFormat, new CultureInfo(EnglishLanguageCode));
        }

        private void NextMonthButton_Click(object sender, EventArgs e)
        {
            selectedDate = selectedDate.AddMonths(NextTimeInterval);
            updateCalendar();
        }

        private void PreviousMonthButton_Click(object sender, EventArgs e)
        {
            selectedDate = selectedDate.AddMonths(PreviousTimeInterval);
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
            if (MonthListBox.SelectedIndex != DefaultSelectedListBoxIndex && YearListBox.SelectedIndex != DefaultSelectedListBoxIndex)
            {
                selectedDate = new DateTime(Int32.Parse(YearListBox.SelectedItem.ToString()), MonthListBox.SelectedIndex + GapBetweenIndexAndNumber, InitialDayOfMonth);
                updateCalendar();
            }
            else
            {
                MessageBox.Show(ErrorMessage);
            }
        }
    }
}
