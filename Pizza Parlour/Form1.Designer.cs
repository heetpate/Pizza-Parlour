namespace Pizza_Parlour
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
            this.pizzaParlour = new System.Windows.Forms.Label();
            this.slices = new System.Windows.Forms.Label();
            this.subTotal = new System.Windows.Forms.Label();
            this.taxAmount = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.sliceInput = new System.Windows.Forms.TextBox();
            this.subtotalOutput = new System.Windows.Forms.TextBox();
            this.taxOutput = new System.Windows.Forms.TextBox();
            this.priceOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pizzaParlour
            // 
            this.pizzaParlour.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pizzaParlour.BackColor = System.Drawing.Color.Red;
            this.pizzaParlour.Font = new System.Drawing.Font("Stencil", 19.25F);
            this.pizzaParlour.ForeColor = System.Drawing.Color.White;
            this.pizzaParlour.Location = new System.Drawing.Point(0, -3);
            this.pizzaParlour.Name = "pizzaParlour";
            this.pizzaParlour.Size = new System.Drawing.Size(806, 64);
            this.pizzaParlour.TabIndex = 0;
            this.pizzaParlour.Text = "Pizza Parlour";
            this.pizzaParlour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pizzaParlour.Click += new System.EventHandler(this.pizzaParlour_Click);
            // 
            // slices
            // 
            this.slices.AutoSize = true;
            this.slices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.slices.ForeColor = System.Drawing.Color.White;
            this.slices.Location = new System.Drawing.Point(268, 94);
            this.slices.Name = "slices";
            this.slices.Size = new System.Drawing.Size(154, 24);
            this.slices.TabIndex = 1;
            this.slices.Text = "Number of Slices";
            // 
            // subTotal
            // 
            this.subTotal.AutoSize = true;
            this.subTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.subTotal.ForeColor = System.Drawing.Color.White;
            this.subTotal.Location = new System.Drawing.Point(332, 238);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(77, 24);
            this.subTotal.TabIndex = 2;
            this.subTotal.Text = "Subtotal";
            // 
            // taxAmount
            // 
            this.taxAmount.AutoSize = true;
            this.taxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.taxAmount.ForeColor = System.Drawing.Color.White;
            this.taxAmount.Location = new System.Drawing.Point(309, 295);
            this.taxAmount.Name = "taxAmount";
            this.taxAmount.Size = new System.Drawing.Size(113, 24);
            this.taxAmount.TabIndex = 3;
            this.taxAmount.Text = "Tax Amount";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.totalPrice.ForeColor = System.Drawing.Color.White;
            this.totalPrice.Location = new System.Drawing.Point(323, 355);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(99, 24);
            this.totalPrice.TabIndex = 4;
            this.totalPrice.Text = "Total Price";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Black;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(370, 158);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(134, 39);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // sliceInput
            // 
            this.sliceInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sliceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.sliceInput.ForeColor = System.Drawing.Color.Black;
            this.sliceInput.Location = new System.Drawing.Point(475, 97);
            this.sliceInput.Name = "sliceInput";
            this.sliceInput.Size = new System.Drawing.Size(100, 26);
            this.sliceInput.TabIndex = 6;
            this.sliceInput.TextChanged += new System.EventHandler(this.sliceInput_TextChanged);
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subtotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.subtotalOutput.ForeColor = System.Drawing.Color.Black;
            this.subtotalOutput.Location = new System.Drawing.Point(475, 236);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(100, 26);
            this.subtotalOutput.TabIndex = 7;
            this.subtotalOutput.TextChanged += new System.EventHandler(this.subtotalOutput_TextChanged);
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.taxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.taxOutput.ForeColor = System.Drawing.Color.Black;
            this.taxOutput.Location = new System.Drawing.Point(475, 295);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(100, 26);
            this.taxOutput.TabIndex = 8;
            // 
            // priceOutput
            // 
            this.priceOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.priceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.priceOutput.ForeColor = System.Drawing.Color.Black;
            this.priceOutput.Location = new System.Drawing.Point(475, 355);
            this.priceOutput.Name = "priceOutput";
            this.priceOutput.Size = new System.Drawing.Size(100, 26);
            this.priceOutput.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.priceOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.sliceInput);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.taxAmount);
            this.Controls.Add(this.subTotal);
            this.Controls.Add(this.slices);
            this.Controls.Add(this.pizzaParlour);
            this.Name = "Form1";
            this.Text = "Pizza Parlour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pizzaParlour;
        private System.Windows.Forms.Label slices;
        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.Label taxAmount;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox sliceInput;
        private System.Windows.Forms.TextBox subtotalOutput;
        private System.Windows.Forms.TextBox taxOutput;
        private System.Windows.Forms.TextBox priceOutput;
    }
}

