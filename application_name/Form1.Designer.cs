using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _button = System.Windows.Forms.Button;
using _panel = System.Windows.Forms.Panel;
using _textField = System.Windows.Forms.TextBox;
using _label = System.Windows.Forms.Label;
using OxyPlot;
using OxyPlot.Series;
using _plotView = OxyPlot.WindowsForms.PlotView;
using _table = System.Windows.Forms.DataGridView;


namespace application_name
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private _button calc;
        private _panel panel0;
        private _panel panel1;
        private _panel panel2;
        private _panel panel3;
        private _textField enterMonths;
        private _textField enterAmount;
        private _label labelName;
        private _plotView plotView = new _plotView();
        private _table dataGridView;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            this.calc = new _button();
            this.panel0 = new _panel();
            this.panel1 = new _panel();
            this.panel2 = new _panel();
            this.panel3 = new _panel();
            this.enterMonths = new _textField();
            this.enterAmount = new _textField();
            this.labelName = new _label();
            this.SuspendLayout();

            this.panel0.Location = new System.Drawing.Point(12, 92);
            this.panel0.Name = "pan0";
            this.panel0.Size = new System.Drawing.Size(224, 500);
            this.panel0.TabIndex = 0;
            this.panel0.Visible = true;
            this.panel0.BackColor = System.Drawing.Color.FromArgb(72, 65, 91);

            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "pan1";
            this.panel1.Size = new System.Drawing.Size(224, 66);
            this.panel1.Visible = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(72, 65, 91);

            this.panel2.Location = new System.Drawing.Point(250, 12);
            this.panel2.Name = "pan2";
            this.panel2.Size = new System.Drawing.Size(320, 580);
            this.panel2.Visible = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(72, 65, 91);

            this.panel3.Location = new System.Drawing.Point(584, 12);
            this.panel3.Name = "pan3";
            this.panel3.Size = new System.Drawing.Size(304, 580);
            this.panel3.Visible = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(72, 65, 91);

            this.labelName.Text = "Interest Calculator";
            this.labelName.Font = new System.Drawing.Font("Felix Titling Regular", 18f, System.Drawing.FontStyle.Regular);
            this.labelName.AutoSize = false;
            this.labelName.Location = new System.Drawing.Point(11, 15);
            this.labelName.Size = new System.Drawing.Size(224, 66);
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);

            this.plotView.Location = new System.Drawing.Point(248, 568);
            this.plotView.Size = new System.Drawing.Size(300, 300);
            this.plotView.PerformLayout();
            this.plotView.Location = new System.Drawing.Point(10, 10);
            this.plotView.Size = new System.Drawing.Size(panel3.Width - 5, panel3.Height - 10);
            this.plotView.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.plotView.Model = CreatePlotModel();

            this.InitializeTable();

            this.calc.Name = "BTN";
            this.calc.Size = new System.Drawing.Size(200, 60);
            this.calc.TabIndex = 1;
            this.calc.Text = "Calculate";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.onCalculate);
            this.calc.Margin = new Padding(10);
            this.calc.Location = new System.Drawing.Point(12, this.panel0.Height - this.calc.Height - 12);
            this.calc.BackColor = System.Drawing.Color.FromArgb(148, 135, 180);
            this.calc.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.calc.Font = new System.Drawing.Font("Felix Titling Regular", 18f, System.Drawing.FontStyle.Regular);
            this.calc.FlatStyle = FlatStyle.Flat;

            this.enterMonths.Name = "Enter months";
            this.enterMonths.Size = new System.Drawing.Size(200, 150);
            this.enterMonths.Margin = new Padding(10);
            this.enterMonths.Location = new System.Drawing.Point(12, 42);

            this.enterAmount.Name = "Enter amount";
            this.enterAmount.Size = new System.Drawing.Size(200, 150);
            this.enterAmount.Margin = new Padding(10);
            this.enterAmount.Location = new System.Drawing.Point(12, 122);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(144, 135, 161);
            this.ClientSize = new System.Drawing.Size(900, 600);

            controllInit();

            this.Name = "Form1";
            this.Text = "Loan Calculator";
            this.ResumeLayout(false);

        }

        private PlotModel CreatePlotModel() {
            var model = new PlotModel {
                Title = "Interest Over Time",
                TitleColor = OxyColors.White,
            };

            model.TitleColor = OxyColors.White;

            var xAxis = new OxyPlot.Axes.LinearAxis {
                Position = OxyPlot.Axes.AxisPosition.Bottom,
                Title = "Time",
                TitleColor = OxyColors.White,
                TextColor = OxyColors.White,
                AxislineColor = OxyColors.White,
                TicklineColor = OxyColors.White
            };

            var yAxis = new OxyPlot.Axes.LinearAxis {
                Position = OxyPlot.Axes.AxisPosition.Left,
                TitleColor = OxyColors.White,
                TextColor = OxyColors.White,
                AxislineColor = OxyColors.White,
                TicklineColor = OxyColors.White
            };

            model.Axes.Add(xAxis);
            model.Axes.Add(yAxis);

            var series = new LineSeries {
                Title = "Interest Growth",
            };

            series.Points.Add(new DataPoint());
            model.Series.Add(series);
            return model;
        }

        private void InitializeTable() {
            dataGridView = new DataGridView {
                Dock = DockStyle.Fill,
                BackgroundColor = System.Drawing.Color.FromArgb(72, 65, 91),
                ForeColor = System.Drawing.Color.White,
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = System.Drawing.Color.FromArgb(144, 135, 161),
                    ForeColor = System.Drawing.Color.White,
                    Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                },
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = System.Drawing.Color.FromArgb(72, 65, 91),
                    ForeColor = System.Drawing.Color.White,
                    Font = new System.Drawing.Font("Arial", 10),
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                },
                EnableHeadersVisualStyles = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill 
            };

            dataGridView.Columns.Add("Month", "Month");
            dataGridView.Columns.Add("Amount", "Amount");
            dataGridView.Columns.Add("Interest", "Interest");
            dataGridView.Columns.Add("Left", "Left");


            for (int i = 0; i < 24; i++)
                dataGridView.Rows.Add("", "", "", "");
            

            this.panel2.Controls.Add(dataGridView);
        }
        
        void controllInit() {
            this.Controls.AddRange(new Control[] { this.panel0, this.panel1, this.panel2, this.panel3});
            this.Controls.AddRange(new Control[] { enterAmount, enterMonths, panel0, calc });
            this.panel0.Controls.AddRange(new Control[] { enterAmount, enterMonths, calc});
            this.panel1.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.dataGridView);
            this.panel3.Controls.AddRange(new Control[] { plotView });
        }

        #endregion
    }
}