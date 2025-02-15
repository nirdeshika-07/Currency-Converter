namespace Live_Currency_Converter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            fromtextBox = new TextBox();
            TotextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            fromcomboBox = new ComboBox();
            tocomboBox = new ComboBox();
            label3 = new Label();
            imageList1 = new ImageList(components);
            convert = new Button();
            SuspendLayout();
            // 
            // fromtextBox
            // 
            fromtextBox.AllowDrop = true;
            fromtextBox.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fromtextBox.Location = new Point(49, 203);
            fromtextBox.Multiline = true;
            fromtextBox.Name = "fromtextBox";
            fromtextBox.Size = new Size(241, 46);
            fromtextBox.TabIndex = 0;
            // 
            // TotextBox
            // 
            TotextBox.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotextBox.Location = new Point(49, 323);
            TotextBox.Multiline = true;
            TotextBox.Name = "TotextBox";
            TotextBox.Size = new Size(241, 46);
            TotextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(49, 155);
            label1.Name = "label1";
            label1.Size = new Size(210, 38);
            label1.TabIndex = 2;
            label1.Text = "From Currency";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(49, 275);
            label2.Name = "label2";
            label2.Size = new Size(171, 38);
            label2.TabIndex = 3;
            label2.Text = "To Currency";
            // 
            // fromcomboBox
            // 
            fromcomboBox.Font = new Font("Segoe UI", 14F);
            fromcomboBox.FormattingEnabled = true;
            fromcomboBox.Location = new Point(345, 203);
            fromcomboBox.Name = "fromcomboBox";
            fromcomboBox.Size = new Size(448, 46);
            fromcomboBox.TabIndex = 4;
            // 
            // tocomboBox
            // 
            tocomboBox.Font = new Font("Segoe UI", 14F);
            tocomboBox.FormattingEnabled = true;
            tocomboBox.Location = new Point(345, 323);
            tocomboBox.Name = "tocomboBox";
            tocomboBox.Size = new Size(448, 46);
            tocomboBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Harrington", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumSeaGreen;
            label3.Location = new Point(58, 9);
            label3.Name = "label3";
            label3.Size = new Size(676, 85);
            label3.TabIndex = 6;
            label3.Text = "Currency Converter";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "money.jpg");
            imageList1.Images.SetKeyName(1, "Rs.jpg");
            // 
            // convert
            // 
            convert.BackColor = Color.MistyRose;
            convert.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            convert.Location = new Point(248, 415);
            convert.Name = "convert";
            convert.Size = new Size(145, 67);
            convert.TabIndex = 7;
            convert.Text = "Convert";
            convert.UseVisualStyleBackColor = false;
            convert.Click += convert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(838, 503);
            Controls.Add(convert);
            Controls.Add(label3);
            Controls.Add(tocomboBox);
            Controls.Add(fromcomboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TotextBox);
            Controls.Add(fromtextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Converter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox fromtextBox;
        private TextBox TotextBox;
        private Label label1;
        private Label label2;
        private ComboBox fromcomboBox;
        private ComboBox tocomboBox;
        private Label label3;
        private ImageList imageList1;
        private Button convert;
    }
}
