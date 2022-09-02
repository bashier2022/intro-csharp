namespace StackCalculator
{
    partial class Form_StackCalculator
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.label_DisplayInput = new System.Windows.Forms.Label();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.listBox_Stack = new System.Windows.Forms.ListBox();
            this.btn_Push = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label_Message = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_Dec = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.ForeColor = System.Drawing.Color.Red;
            this.btn_1.Location = new System.Drawing.Point(68, 190);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(50, 50);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.OnDigit_click);
            // 
            // label_DisplayInput
            // 
            this.label_DisplayInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_DisplayInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DisplayInput.ForeColor = System.Drawing.Color.Red;
            this.label_DisplayInput.Location = new System.Drawing.Point(77, 83);
            this.label_DisplayInput.Name = "label_DisplayInput";
            this.label_DisplayInput.Size = new System.Drawing.Size(162, 39);
            this.label_DisplayInput.TabIndex = 1;
            this.label_DisplayInput.Text = "0";
            this.label_DisplayInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.ForeColor = System.Drawing.Color.Red;
            this.btn_2.Location = new System.Drawing.Point(124, 190);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(50, 50);
            this.btn_2.TabIndex = 0;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.OnDigit_click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.ForeColor = System.Drawing.Color.Red;
            this.btn_3.Location = new System.Drawing.Point(180, 190);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(50, 50);
            this.btn_3.TabIndex = 0;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.OnDigit_click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.ForeColor = System.Drawing.Color.Red;
            this.btn_4.Location = new System.Drawing.Point(68, 246);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(50, 50);
            this.btn_4.TabIndex = 0;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.OnDigit_click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.ForeColor = System.Drawing.Color.Red;
            this.btn_5.Location = new System.Drawing.Point(124, 246);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(50, 50);
            this.btn_5.TabIndex = 0;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.OnDigit_click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.ForeColor = System.Drawing.Color.Red;
            this.btn_6.Location = new System.Drawing.Point(180, 246);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(50, 50);
            this.btn_6.TabIndex = 0;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.OnDigit_click);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.ForeColor = System.Drawing.Color.Red;
            this.btn_7.Location = new System.Drawing.Point(68, 302);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(50, 50);
            this.btn_7.TabIndex = 0;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.OnDigit_click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.ForeColor = System.Drawing.Color.Red;
            this.btn_8.Location = new System.Drawing.Point(124, 302);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(50, 50);
            this.btn_8.TabIndex = 0;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.OnDigit_click);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.ForeColor = System.Drawing.Color.Red;
            this.btn_9.Location = new System.Drawing.Point(180, 302);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(50, 50);
            this.btn_9.TabIndex = 0;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.OnDigit_click);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.ForeColor = System.Drawing.Color.Red;
            this.btn_0.Location = new System.Drawing.Point(124, 134);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(50, 50);
            this.btn_0.TabIndex = 0;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.OnDigit_click);
            // 
            // listBox_Stack
            // 
            this.listBox_Stack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Stack.FormattingEnabled = true;
            this.listBox_Stack.ItemHeight = 20;
            this.listBox_Stack.Location = new System.Drawing.Point(259, 128);
            this.listBox_Stack.Name = "listBox_Stack";
            this.listBox_Stack.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_Stack.Size = new System.Drawing.Size(124, 184);
            this.listBox_Stack.TabIndex = 2;
            // 
            // btn_Push
            // 
            this.btn_Push.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Push.ForeColor = System.Drawing.Color.Red;
            this.btn_Push.Location = new System.Drawing.Point(259, 83);
            this.btn_Push.Name = "btn_Push";
            this.btn_Push.Size = new System.Drawing.Size(124, 39);
            this.btn_Push.TabIndex = 0;
            this.btn_Push.Text = "Push";
            this.btn_Push.UseVisualStyleBackColor = true;
            this.btn_Push.Click += new System.EventHandler(this.OnPush_click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(389, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "/";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnOperation_click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(389, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 0;
            this.button2.Text = "*";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnOperation_click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(389, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 0;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OnOperation_click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(389, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 0;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OnOperation_click);
            // 
            // label_Message
            // 
            this.label_Message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Message.ForeColor = System.Drawing.Color.Red;
            this.label_Message.Location = new System.Drawing.Point(77, 378);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(361, 37);
            this.label_Message.TabIndex = 3;
            this.label_Message.Text = "Message:";
            this.label_Message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(77, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "The Integer Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(180, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 0;
            this.button5.Text = "Inc";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Inc_Dec_click);
            // 
            // btn_Dec
            // 
            this.btn_Dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dec.ForeColor = System.Drawing.Color.Red;
            this.btn_Dec.Location = new System.Drawing.Point(68, 134);
            this.btn_Dec.Name = "btn_Dec";
            this.btn_Dec.Size = new System.Drawing.Size(50, 50);
            this.btn_Dec.TabIndex = 0;
            this.btn_Dec.Text = "Dec";
            this.btn_Dec.UseVisualStyleBackColor = true;
            this.btn_Dec.Click += new System.EventHandler(this.Inc_Dec_click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.ForeColor = System.Drawing.Color.Red;
            this.btn_del.Location = new System.Drawing.Point(12, 83);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(50, 43);
            this.btn_del.TabIndex = 0;
            this.btn_del.Text = "Del";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.Delete_Clear_click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Red;
            this.btn_Clear.Location = new System.Drawing.Point(259, 318);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(124, 43);
            this.btn_Clear.TabIndex = 0;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Delete_Clear_click);
            // 
            // Form_StackCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.listBox_Stack);
            this.Controls.Add(this.label_DisplayInput);
            this.Controls.Add(this.btn_Push);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_Dec);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_StackCalculator";
            this.Text = "Stack Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Label label_DisplayInput;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.ListBox listBox_Stack;
        private System.Windows.Forms.Button btn_Push;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_Dec;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_Clear;
    }
}

