namespace Calendar
{
    partial class CalendarForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nextMonthButton = new System.Windows.Forms.Button();
            this.calendarTable = new System.Windows.Forms.TableLayoutPanel();
            this.previousMonthButton = new System.Windows.Forms.Button();
            this.daysOfWeekTable = new System.Windows.Forms.TableLayoutPanel();
            this.sundayLabel = new System.Windows.Forms.Label();
            this.saturdayLabel = new System.Windows.Forms.Label();
            this.fridayLabel = new System.Windows.Forms.Label();
            this.ThursdayLabel = new System.Windows.Forms.Label();
            this.WednesdayLabel = new System.Windows.Forms.Label();
            this.TuesdayLabel = new System.Windows.Forms.Label();
            this.mondayLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.todayButton = new System.Windows.Forms.Button();
            this.MonthListBox = new System.Windows.Forms.ListBox();
            this.YearListBox = new System.Windows.Forms.ListBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.daysOfWeekTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextMonthButton
            // 
            this.nextMonthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextMonthButton.Location = new System.Drawing.Point(164, 7);
            this.nextMonthButton.Name = "nextMonthButton";
            this.nextMonthButton.Size = new System.Drawing.Size(28, 28);
            this.nextMonthButton.TabIndex = 1;
            this.nextMonthButton.Text = ">";
            this.nextMonthButton.UseVisualStyleBackColor = true;
            this.nextMonthButton.Click += new System.EventHandler(this.NextMonthButton_Click);
            // 
            // calendarTable
            // 
            this.calendarTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.calendarTable.ColumnCount = 7;
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendarTable.Location = new System.Drawing.Point(12, 71);
            this.calendarTable.Margin = new System.Windows.Forms.Padding(0);
            this.calendarTable.Name = "calendarTable";
            this.calendarTable.RowCount = 1;
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.calendarTable.Size = new System.Drawing.Size(776, 367);
            this.calendarTable.TabIndex = 1;
            this.calendarTable.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.CalendarTable_CellPaint);
            // 
            // previousMonthButton
            // 
            this.previousMonthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.previousMonthButton.Location = new System.Drawing.Point(130, 7);
            this.previousMonthButton.Name = "previousMonthButton";
            this.previousMonthButton.Size = new System.Drawing.Size(28, 28);
            this.previousMonthButton.TabIndex = 2;
            this.previousMonthButton.Text = "<";
            this.previousMonthButton.UseVisualStyleBackColor = true;
            this.previousMonthButton.Click += new System.EventHandler(this.PreviousMonthButton_Click);
            // 
            // daysOfWeekTable
            // 
            this.daysOfWeekTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.daysOfWeekTable.ColumnCount = 7;
            this.daysOfWeekTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.daysOfWeekTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.daysOfWeekTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.daysOfWeekTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.daysOfWeekTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.daysOfWeekTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.daysOfWeekTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.daysOfWeekTable.Controls.Add(this.sundayLabel, 6, 0);
            this.daysOfWeekTable.Controls.Add(this.saturdayLabel, 5, 0);
            this.daysOfWeekTable.Controls.Add(this.fridayLabel, 4, 0);
            this.daysOfWeekTable.Controls.Add(this.ThursdayLabel, 3, 0);
            this.daysOfWeekTable.Controls.Add(this.WednesdayLabel, 2, 0);
            this.daysOfWeekTable.Controls.Add(this.TuesdayLabel, 1, 0);
            this.daysOfWeekTable.Controls.Add(this.mondayLabel, 0, 0);
            this.daysOfWeekTable.Location = new System.Drawing.Point(12, 42);
            this.daysOfWeekTable.Margin = new System.Windows.Forms.Padding(0);
            this.daysOfWeekTable.Name = "daysOfWeekTable";
            this.daysOfWeekTable.RowCount = 1;
            this.daysOfWeekTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.daysOfWeekTable.Size = new System.Drawing.Size(776, 29);
            this.daysOfWeekTable.TabIndex = 3;
            this.daysOfWeekTable.Tag = "";
            // 
            // sundayLabel
            // 
            this.sundayLabel.AutoSize = true;
            this.sundayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sundayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sundayLabel.Location = new System.Drawing.Point(664, 1);
            this.sundayLabel.Name = "sundayLabel";
            this.sundayLabel.Size = new System.Drawing.Size(108, 27);
            this.sundayLabel.TabIndex = 6;
            this.sundayLabel.Text = "Sunday";
            this.sundayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saturdayLabel
            // 
            this.saturdayLabel.AutoSize = true;
            this.saturdayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saturdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saturdayLabel.Location = new System.Drawing.Point(554, 1);
            this.saturdayLabel.Name = "saturdayLabel";
            this.saturdayLabel.Size = new System.Drawing.Size(103, 27);
            this.saturdayLabel.TabIndex = 5;
            this.saturdayLabel.Text = "Saturday";
            this.saturdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fridayLabel
            // 
            this.fridayLabel.AutoSize = true;
            this.fridayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fridayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fridayLabel.Location = new System.Drawing.Point(444, 1);
            this.fridayLabel.Name = "fridayLabel";
            this.fridayLabel.Size = new System.Drawing.Size(103, 27);
            this.fridayLabel.TabIndex = 4;
            this.fridayLabel.Text = "Friday";
            this.fridayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThursdayLabel
            // 
            this.ThursdayLabel.AutoSize = true;
            this.ThursdayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThursdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ThursdayLabel.Location = new System.Drawing.Point(334, 1);
            this.ThursdayLabel.Name = "ThursdayLabel";
            this.ThursdayLabel.Size = new System.Drawing.Size(103, 27);
            this.ThursdayLabel.TabIndex = 3;
            this.ThursdayLabel.Text = "Thursday";
            this.ThursdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WednesdayLabel
            // 
            this.WednesdayLabel.AutoSize = true;
            this.WednesdayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WednesdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WednesdayLabel.Location = new System.Drawing.Point(224, 1);
            this.WednesdayLabel.Name = "WednesdayLabel";
            this.WednesdayLabel.Size = new System.Drawing.Size(103, 27);
            this.WednesdayLabel.TabIndex = 2;
            this.WednesdayLabel.Text = "Wednesday";
            this.WednesdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TuesdayLabel
            // 
            this.TuesdayLabel.AutoSize = true;
            this.TuesdayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TuesdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TuesdayLabel.Location = new System.Drawing.Point(114, 1);
            this.TuesdayLabel.Name = "TuesdayLabel";
            this.TuesdayLabel.Size = new System.Drawing.Size(103, 27);
            this.TuesdayLabel.TabIndex = 1;
            this.TuesdayLabel.Text = "Tuesday";
            this.TuesdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mondayLabel
            // 
            this.mondayLabel.AutoSize = true;
            this.mondayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mondayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mondayLabel.Location = new System.Drawing.Point(4, 1);
            this.mondayLabel.Name = "mondayLabel";
            this.mondayLabel.Size = new System.Drawing.Size(103, 27);
            this.mondayLabel.TabIndex = 0;
            this.mondayLabel.Text = "Monday";
            this.mondayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.monthLabel.Location = new System.Drawing.Point(235, 7);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(120, 29);
            this.monthLabel.TabIndex = 4;
            this.monthLabel.Text = "April 2019";
            // 
            // todayButton
            // 
            this.todayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.todayButton.Location = new System.Drawing.Point(12, 8);
            this.todayButton.Name = "todayButton";
            this.todayButton.Size = new System.Drawing.Size(75, 28);
            this.todayButton.TabIndex = 5;
            this.todayButton.Text = "Today";
            this.todayButton.UseVisualStyleBackColor = true;
            this.todayButton.Click += new System.EventHandler(this.TodayButton_Click);
            // 
            // MonthListBox
            // 
            this.MonthListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MonthListBox.FormattingEnabled = true;
            this.MonthListBox.ItemHeight = 20;
            this.MonthListBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthListBox.Location = new System.Drawing.Point(459, 7);
            this.MonthListBox.Name = "MonthListBox";
            this.MonthListBox.Size = new System.Drawing.Size(100, 24);
            this.MonthListBox.TabIndex = 6;
            // 
            // YearListBox
            // 
            this.YearListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.YearListBox.FormattingEnabled = true;
            this.YearListBox.ItemHeight = 20;
            this.YearListBox.Items.AddRange(new object[] {
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015"});
            this.YearListBox.Location = new System.Drawing.Point(570, 7);
            this.YearListBox.Name = "YearListBox";
            this.YearListBox.Size = new System.Drawing.Size(100, 24);
            this.YearListBox.TabIndex = 7;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SearchButton.Location = new System.Drawing.Point(699, 6);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(89, 28);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.YearListBox);
            this.Controls.Add(this.MonthListBox);
            this.Controls.Add(this.todayButton);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.daysOfWeekTable);
            this.Controls.Add(this.previousMonthButton);
            this.Controls.Add(this.calendarTable);
            this.Controls.Add(this.nextMonthButton);
            this.Name = "CalendarForm";
            this.Text = "Calendario";
            this.daysOfWeekTable.ResumeLayout(false);
            this.daysOfWeekTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button nextMonthButton;
        private System.Windows.Forms.TableLayoutPanel calendarTable;
        private System.Windows.Forms.Button previousMonthButton;
        private System.Windows.Forms.TableLayoutPanel daysOfWeekTable;
        private System.Windows.Forms.Label mondayLabel;
        private System.Windows.Forms.Label sundayLabel;
        private System.Windows.Forms.Label saturdayLabel;
        private System.Windows.Forms.Label fridayLabel;
        private System.Windows.Forms.Label ThursdayLabel;
        private System.Windows.Forms.Label WednesdayLabel;
        private System.Windows.Forms.Label TuesdayLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Button todayButton;
        private System.Windows.Forms.ListBox MonthListBox;
        private System.Windows.Forms.ListBox YearListBox;
        private System.Windows.Forms.Button SearchButton;
    }
}

