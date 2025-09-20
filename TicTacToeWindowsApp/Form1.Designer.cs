namespace SnakeAndLadder
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            textBox00 = new TextBox();
            textBox10 = new TextBox();
            textBox20 = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            textBox01 = new TextBox();
            textBox11 = new TextBox();
            textBox21 = new TextBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            textBox02 = new TextBox();
            textBox12 = new TextBox();
            textBox22 = new TextBox();
            gameStatusLbl = new Label();
            currentPlayerLbl = new Label();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Location = new Point(370, 67);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(261, 140);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(textBox00);
            flowLayoutPanel2.Controls.Add(textBox10);
            flowLayoutPanel2.Controls.Add(textBox20);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(80, 129);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // textBox00
            // 
            textBox00.Location = new Point(3, 3);
            textBox00.MaxLength = 1;
            textBox00.Name = "textBox00";
            textBox00.Size = new Size(61, 34);
            textBox00.TabIndex = 0;
            textBox00.KeyPress += textBox_KeyPress;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(3, 43);
            textBox10.MaxLength = 1;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(61, 34);
            textBox10.TabIndex = 1;
            textBox10.KeyPress += textBox_KeyPress;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(3, 83);
            textBox20.MaxLength = 1;
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(61, 34);
            textBox20.TabIndex = 2;
            textBox20.KeyPress += textBox_KeyPress;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(textBox01);
            flowLayoutPanel3.Controls.Add(textBox11);
            flowLayoutPanel3.Controls.Add(textBox21);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(89, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(80, 129);
            flowLayoutPanel3.TabIndex = 3;
            // 
            // textBox01
            // 
            textBox01.Location = new Point(3, 3);
            textBox01.MaxLength = 1;
            textBox01.Name = "textBox01";
            textBox01.Size = new Size(61, 34);
            textBox01.TabIndex = 0;
            textBox01.KeyPress += textBox_KeyPress;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(3, 43);
            textBox11.MaxLength = 1;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(61, 34);
            textBox11.TabIndex = 1;
            textBox11.KeyPress += textBox_KeyPress;
            // 
            // textBox21
            // 
            textBox21.Location = new Point(3, 83);
            textBox21.MaxLength = 1;
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(61, 34);
            textBox21.TabIndex = 2;
            textBox21.KeyPress += textBox_KeyPress;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(textBox02);
            flowLayoutPanel4.Controls.Add(textBox12);
            flowLayoutPanel4.Controls.Add(textBox22);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(175, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(80, 129);
            flowLayoutPanel4.TabIndex = 4;
            // 
            // textBox02
            // 
            textBox02.Location = new Point(3, 3);
            textBox02.MaxLength = 1;
            textBox02.Name = "textBox02";
            textBox02.Size = new Size(61, 34);
            textBox02.TabIndex = 0;
            textBox02.KeyPress += textBox_KeyPress;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(3, 43);
            textBox12.MaxLength = 1;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(61, 34);
            textBox12.TabIndex = 1;
            textBox12.KeyPress += textBox_KeyPress;
            // 
            // textBox22
            // 
            textBox22.Location = new Point(3, 83);
            textBox22.MaxLength = 1;
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(61, 34);
            textBox22.TabIndex = 2;
            textBox22.KeyPress += textBox_KeyPress;
            // 
            // gameStatusLbl
            // 
            gameStatusLbl.AutoSize = true;
            gameStatusLbl.Location = new Point(356, 301);
            gameStatusLbl.Name = "gameStatusLbl";
            gameStatusLbl.Size = new Size(65, 28);
            gameStatusLbl.TabIndex = 1;
            gameStatusLbl.Text = "label1";
            // 
            // currentPlayerLbl
            // 
            currentPlayerLbl.AutoSize = true;
            currentPlayerLbl.Location = new Point(131, 31);
            currentPlayerLbl.Name = "currentPlayerLbl";
            currentPlayerLbl.Size = new Size(65, 28);
            currentPlayerLbl.TabIndex = 2;
            currentPlayerLbl.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(currentPlayerLbl);
            Controls.Add(gameStatusLbl);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox textBox00;
        private TextBox textBox10;
        private TextBox textBox20;
        private FlowLayoutPanel flowLayoutPanel3;
        private TextBox textBox01;
        private TextBox textBox11;
        private TextBox textBox21;
        private FlowLayoutPanel flowLayoutPanel4;
        private TextBox textBox02;
        private TextBox textBox12;
        private TextBox textBox22;
        private Label gameStatusLbl;
        private Label currentPlayerLbl;
    }
}
