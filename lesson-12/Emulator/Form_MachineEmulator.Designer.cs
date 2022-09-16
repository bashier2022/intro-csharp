namespace Emulator
{
    partial class Form_MachineEmulator
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
            this.textBox_ProgramCode = new System.Windows.Forms.TextBox();
            this.label_ProgEditor = new System.Windows.Forms.Label();
            this.listBox_StackViewer = new System.Windows.Forms.ListBox();
            this.listBox_ExeCode = new System.Windows.Forms.ListBox();
            this.label_ExeCode = new System.Windows.Forms.Label();
            this.label_DataStack = new System.Windows.Forms.Label();
            this.btn_Build = new System.Windows.Forms.Button();
            this.btn_ExecuteStep = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.textBox_ExecutingMessage = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label_PC = new System.Windows.Forms.Label();
            this.listBox_IPStackViewer = new System.Windows.Forms.ListBox();
            this.textBox_MemoryDisplay = new System.Windows.Forms.TextBox();
            this.pictureBox_MemoryImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MemoryImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_ProgramCode
            // 
            this.textBox_ProgramCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_ProgramCode.Location = new System.Drawing.Point(38, 58);
            this.textBox_ProgramCode.Multiline = true;
            this.textBox_ProgramCode.Name = "textBox_ProgramCode";
            this.textBox_ProgramCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ProgramCode.Size = new System.Drawing.Size(158, 455);
            this.textBox_ProgramCode.TabIndex = 0;
            this.textBox_ProgramCode.Text = "PUSH 0\r\nPUSH 1\r\nDUP\r\nINC\r\nDUP\r\nPUSH 10\r\nSUB\r\nJNZ 2\r\n";
            // 
            // label_ProgEditor
            // 
            this.label_ProgEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_ProgEditor.Location = new System.Drawing.Point(41, 20);
            this.label_ProgEditor.Name = "label_ProgEditor";
            this.label_ProgEditor.Size = new System.Drawing.Size(155, 26);
            this.label_ProgEditor.TabIndex = 1;
            this.label_ProgEditor.Text = "Program Editor";
            this.label_ProgEditor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox_StackViewer
            // 
            this.listBox_StackViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBox_StackViewer.FormattingEnabled = true;
            this.listBox_StackViewer.ItemHeight = 20;
            this.listBox_StackViewer.Location = new System.Drawing.Point(364, 58);
            this.listBox_StackViewer.Name = "listBox_StackViewer";
            this.listBox_StackViewer.Size = new System.Drawing.Size(94, 364);
            this.listBox_StackViewer.TabIndex = 2;
            // 
            // listBox_ExeCode
            // 
            this.listBox_ExeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBox_ExeCode.FormattingEnabled = true;
            this.listBox_ExeCode.ItemHeight = 20;
            this.listBox_ExeCode.Location = new System.Drawing.Point(212, 58);
            this.listBox_ExeCode.Name = "listBox_ExeCode";
            this.listBox_ExeCode.Size = new System.Drawing.Size(140, 444);
            this.listBox_ExeCode.TabIndex = 2;
            // 
            // label_ExeCode
            // 
            this.label_ExeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_ExeCode.Location = new System.Drawing.Point(209, 20);
            this.label_ExeCode.Name = "label_ExeCode";
            this.label_ExeCode.Size = new System.Drawing.Size(155, 26);
            this.label_ExeCode.TabIndex = 1;
            this.label_ExeCode.Text = "Executable Code";
            this.label_ExeCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_DataStack
            // 
            this.label_DataStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_DataStack.Location = new System.Drawing.Point(361, 20);
            this.label_DataStack.Name = "label_DataStack";
            this.label_DataStack.Size = new System.Drawing.Size(155, 26);
            this.label_DataStack.TabIndex = 1;
            this.label_DataStack.Text = "Stack Display";
            this.label_DataStack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Build
            // 
            this.btn_Build.Location = new System.Drawing.Point(40, 519);
            this.btn_Build.Name = "btn_Build";
            this.btn_Build.Size = new System.Drawing.Size(156, 35);
            this.btn_Build.TabIndex = 3;
            this.btn_Build.Text = "Build";
            this.btn_Build.UseVisualStyleBackColor = true;
            this.btn_Build.Click += new System.EventHandler(this.BuildCode_Click);
            // 
            // btn_ExecuteStep
            // 
            this.btn_ExecuteStep.Location = new System.Drawing.Point(212, 519);
            this.btn_ExecuteStep.Name = "btn_ExecuteStep";
            this.btn_ExecuteStep.Size = new System.Drawing.Size(140, 35);
            this.btn_ExecuteStep.TabIndex = 3;
            this.btn_ExecuteStep.Text = "Execute Step";
            this.btn_ExecuteStep.UseVisualStyleBackColor = true;
            this.btn_ExecuteStep.Click += new System.EventHandler(this.ExecuteStep_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(40, 560);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(156, 35);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // textBox_ExecutingMessage
            // 
            this.textBox_ExecutingMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_ExecutingMessage.ForeColor = System.Drawing.Color.Red;
            this.textBox_ExecutingMessage.Location = new System.Drawing.Point(389, 479);
            this.textBox_ExecutingMessage.Name = "textBox_ExecutingMessage";
            this.textBox_ExecutingMessage.Size = new System.Drawing.Size(161, 23);
            this.textBox_ExecutingMessage.TabIndex = 4;
            this.textBox_ExecutingMessage.Text = "Executing";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 560);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "RUN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Run_Click);
            // 
            // label_PC
            // 
            this.label_PC.AutoSize = true;
            this.label_PC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_PC.Location = new System.Drawing.Point(386, 446);
            this.label_PC.Name = "label_PC";
            this.label_PC.Size = new System.Drawing.Size(23, 13);
            this.label_PC.TabIndex = 5;
            this.label_PC.Text = "PC";
            // 
            // listBox_IPStackViewer
            // 
            this.listBox_IPStackViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBox_IPStackViewer.FormattingEnabled = true;
            this.listBox_IPStackViewer.ItemHeight = 20;
            this.listBox_IPStackViewer.Location = new System.Drawing.Point(464, 58);
            this.listBox_IPStackViewer.Name = "listBox_IPStackViewer";
            this.listBox_IPStackViewer.Size = new System.Drawing.Size(102, 364);
            this.listBox_IPStackViewer.TabIndex = 2;
            // 
            // textBox_MemoryDisplay
            // 
            this.textBox_MemoryDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_MemoryDisplay.Location = new System.Drawing.Point(595, 58);
            this.textBox_MemoryDisplay.Multiline = true;
            this.textBox_MemoryDisplay.Name = "textBox_MemoryDisplay";
            this.textBox_MemoryDisplay.ReadOnly = true;
            this.textBox_MemoryDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_MemoryDisplay.Size = new System.Drawing.Size(217, 547);
            this.textBox_MemoryDisplay.TabIndex = 6;
            // 
            // pictureBox_MemoryImage
            // 
            this.pictureBox_MemoryImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_MemoryImage.Location = new System.Drawing.Point(847, 12);
            this.pictureBox_MemoryImage.Name = "pictureBox_MemoryImage";
            this.pictureBox_MemoryImage.Size = new System.Drawing.Size(360, 600);
            this.pictureBox_MemoryImage.TabIndex = 7;
            this.pictureBox_MemoryImage.TabStop = false;
            // 
            // Form_MachineEmulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 617);
            this.Controls.Add(this.pictureBox_MemoryImage);
            this.Controls.Add(this.textBox_MemoryDisplay);
            this.Controls.Add(this.label_PC);
            this.Controls.Add(this.textBox_ExecutingMessage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_ExecuteStep);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Build);
            this.Controls.Add(this.listBox_ExeCode);
            this.Controls.Add(this.listBox_IPStackViewer);
            this.Controls.Add(this.listBox_StackViewer);
            this.Controls.Add(this.label_DataStack);
            this.Controls.Add(this.label_ExeCode);
            this.Controls.Add(this.label_ProgEditor);
            this.Controls.Add(this.textBox_ProgramCode);
            this.Name = "Form_MachineEmulator";
            this.Text = "Machine Emulator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MemoryImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ProgramCode;
        private System.Windows.Forms.Label label_ProgEditor;
        private System.Windows.Forms.ListBox listBox_StackViewer;
        private System.Windows.Forms.ListBox listBox_ExeCode;
        private System.Windows.Forms.Label label_ExeCode;
        private System.Windows.Forms.Label label_DataStack;
        private System.Windows.Forms.Button btn_Build;
        private System.Windows.Forms.Button btn_ExecuteStep;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox textBox_ExecutingMessage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_PC;
        private System.Windows.Forms.ListBox listBox_IPStackViewer;
        private System.Windows.Forms.TextBox textBox_MemoryDisplay;
        private System.Windows.Forms.PictureBox pictureBox_MemoryImage;
    }
}

