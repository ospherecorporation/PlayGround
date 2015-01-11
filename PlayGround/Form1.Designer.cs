namespace PlayGround
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.c1Calendar1 = new C1.Win.C1Schedule.C1Calendar();
            this.c1QRCode1 = new C1.Win.C1BarCode.C1QRCode();
            this.c1Button1 = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Calendar1
            // 
            this.c1Calendar1.BoldedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.c1Calendar1.CalendarInfo.CultureInfo = new System.Globalization.CultureInfo("en-PH");
            this.c1Calendar1.CalendarInfo.DateFormatString = "M/d/yyyy";
            this.c1Calendar1.CalendarInfo.EndDayTime = System.TimeSpan.Parse("19:00:00");
            this.c1Calendar1.CalendarInfo.StartDayTime = System.TimeSpan.Parse("07:00:00");
            this.c1Calendar1.CalendarInfo.TimeScale = System.TimeSpan.Parse("00:30:00");
            this.c1Calendar1.CalendarInfo.WeekStart = System.DayOfWeek.Sunday;
            this.c1Calendar1.CalendarInfo.WorkDays.AddRange(new System.DayOfWeek[] {
            System.DayOfWeek.Monday,
            System.DayOfWeek.Tuesday,
            System.DayOfWeek.Wednesday,
            System.DayOfWeek.Thursday,
            System.DayOfWeek.Friday});
            this.c1Calendar1.Location = new System.Drawing.Point(12, 84);
            this.c1Calendar1.Name = "c1Calendar1";
            this.c1Calendar1.Size = new System.Drawing.Size(181, 142);
            this.c1Calendar1.TabIndex = 0;
            // 
            // c1QRCode1
            // 
            this.c1QRCode1.Location = new System.Drawing.Point(12, 12);
            this.c1QRCode1.Name = "c1QRCode1";
            this.c1QRCode1.Size = new System.Drawing.Size(66, 66);
            this.c1QRCode1.TabIndex = 1;
            this.c1QRCode1.Text = "c1QRCode1";
            // 
            // c1Button1
            // 
            this.c1Button1.Location = new System.Drawing.Point(97, 48);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Size = new System.Drawing.Size(75, 23);
            this.c1Button1.TabIndex = 2;
            this.c1Button1.Text = "c1Button1";
            this.c1Button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 443);
            this.Controls.Add(this.c1Button1);
            this.Controls.Add(this.c1QRCode1);
            this.Controls.Add(this.c1Calendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Schedule.C1Calendar c1Calendar1;
        private C1.Win.C1BarCode.C1QRCode c1QRCode1;
        private C1.Win.C1Input.C1Button c1Button1;
    }
}

