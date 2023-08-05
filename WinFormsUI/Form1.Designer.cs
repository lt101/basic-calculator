namespace WinFormsUI
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
            firstValue = new Label();
            firstValueText = new TextBox();
            secondValueText = new TextBox();
            secondValue = new Label();
            operationType = new TextBox();
            operation = new Label();
            compute = new Button();
            SuspendLayout();
            // 
            // firstValue
            // 
            firstValue.AutoSize = true;
            firstValue.Location = new Point(100, 93);
            firstValue.Name = "firstValue";
            firstValue.Size = new Size(136, 37);
            firstValue.TabIndex = 0;
            firstValue.Text = "First value";
            // 
            // firstValueText
            // 
            firstValueText.Location = new Point(280, 93);
            firstValueText.Name = "firstValueText";
            firstValueText.Size = new Size(139, 43);
            firstValueText.TabIndex = 1;
            // 
            // secondValueText
            // 
            secondValueText.Location = new Point(280, 156);
            secondValueText.Name = "secondValueText";
            secondValueText.Size = new Size(139, 43);
            secondValueText.TabIndex = 3;
            // 
            // secondValue
            // 
            secondValue.AutoSize = true;
            secondValue.Location = new Point(100, 156);
            secondValue.Name = "secondValue";
            secondValue.Size = new Size(174, 37);
            secondValue.TabIndex = 2;
            secondValue.Text = "Second value";
            // 
            // operationType
            // 
            operationType.Location = new Point(280, 219);
            operationType.Name = "operationType";
            operationType.Size = new Size(139, 43);
            operationType.TabIndex = 5;
            // 
            // operation
            // 
            operation.AutoSize = true;
            operation.Location = new Point(100, 219);
            operation.Name = "operation";
            operation.Size = new Size(137, 37);
            operation.TabIndex = 4;
            operation.Text = "Operation";
            // 
            // compute
            // 
            compute.Location = new Point(216, 310);
            compute.Name = "compute";
            compute.Size = new Size(138, 53);
            compute.TabIndex = 6;
            compute.Text = "Compute";
            compute.UseVisualStyleBackColor = true;
            compute.Click += compute_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 412);
            Controls.Add(compute);
            Controls.Add(operationType);
            Controls.Add(operation);
            Controls.Add(secondValueText);
            Controls.Add(secondValue);
            Controls.Add(firstValueText);
            Controls.Add(firstValue);
            Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstValue;
        private TextBox firstValueText;
        private TextBox secondValueText;
        private Label secondValue;
        private TextBox operationType;
        private Label operation;
        private Button compute;
    }
}