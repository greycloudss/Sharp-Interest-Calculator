using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _button = System.Windows.Forms.Button;
using _panel = System.Windows.Forms.Panel;
using _textField = System.Windows.Forms.TextBox;
using _label = System.Windows.Forms.Label;

namespace application_name
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private _button calc;
        private _panel panel0;
        private _panel panel1;
        private _textField enterMonths;
        private _textField enterAmount;
        private _label labelName;
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

            this.labelName.Text = "Interest Calculator";
            this.labelName.Font = new System.Drawing.Font("Felix Titling Regular", 18f, System.Drawing.FontStyle.Regular);
            this.labelName.AutoSize = false;
            this.labelName.Location = new System.Drawing.Point(11, 15);
            this.labelName.Size = new System.Drawing.Size(224, 66);
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);

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


        void controllInit() {
            this.Controls.AddRange(new Control[] { this.panel0, this.panel1 });
            this.panel1.Controls.Add(this.labelName);
            this.Controls.AddRange(new Control[] { enterAmount, enterMonths, panel0, calc });
            this.panel0.Controls.AddRange(new Control[] { enterAmount, enterMonths, calc});
        }

        #endregion
    }
}

