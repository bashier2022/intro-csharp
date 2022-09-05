namespace StackCalculator
{
    partial class Form_CounterClass
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
            this.btn_Inc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_Counter = new System.Windows.Forms.Label();
            this.btn_SetValue = new System.Windows.Forms.Button();
            this.textBox_Value = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Inc
            // 
            this.btn_Inc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Inc.Location = new System.Drawing.Point(33, 75);
            this.btn_Inc.Name = "btn_Inc";
            this.btn_Inc.Size = new System.Drawing.Size(70, 40);
            this.btn_Inc.TabIndex = 0;
            this.btn_Inc.Text = "Inc";
            this.btn_Inc.UseVisualStyleBackColor = true;
            this.btn_Inc.Click += new System.EventHandler(this.btn_Inc_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(33, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dec";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Counter
            // 
            this.label_Counter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Counter.ForeColor = System.Drawing.Color.Red;
            this.label_Counter.Location = new System.Drawing.Point(137, 106);
            this.label_Counter.Name = "label_Counter";
            this.label_Counter.Size = new System.Drawing.Size(90, 30);
            this.label_Counter.TabIndex = 1;
            this.label_Counter.Text = "0";
            this.label_Counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_SetValue
            // 
            this.btn_SetValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SetValue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_SetValue.Location = new System.Drawing.Point(33, 189);
            this.btn_SetValue.Name = "btn_SetValue";
            this.btn_SetValue.Size = new System.Drawing.Size(70, 40);
            this.btn_SetValue.TabIndex = 0;
            this.btn_SetValue.Text = "Set";
            this.btn_SetValue.UseVisualStyleBackColor = true;
            this.btn_SetValue.Click += new System.EventHandler(this.btn_SetValue_Click);
            // 
            // textBox_Value
            // 
            this.textBox_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Value.ForeColor = System.Drawing.Color.Red;
            this.textBox_Value.Location = new System.Drawing.Point(109, 195);
            this.textBox_Value.Name = "textBox_Value";
            this.textBox_Value.Size = new System.Drawing.Size(109, 34);
            this.textBox_Value.TabIndex = 2;
            // 
            // Form_CounterClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.textBox_Value);
            this.Controls.Add(this.label_Counter);
            this.Controls.Add(this.btn_SetValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Inc);
            this.Name = "Form_CounterClass";
            this.Text = "Form_CounterClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Inc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Counter;
        private System.Windows.Forms.Button btn_SetValue;
        private System.Windows.Forms.TextBox textBox_Value;
    }
}