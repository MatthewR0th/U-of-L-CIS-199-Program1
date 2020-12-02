namespace Program1
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
            this.label1 = new System.Windows.Forms.Label();
            this.maxWidthTextbox = new System.Windows.Forms.TextBox();
            this.underlayCost = new System.Windows.Forms.Label();
            this.hardwoodPrice = new System.Windows.Forms.Label();
            this.MaxLengthOfRoom = new System.Windows.Forms.Label();
            this.maxWidthofRoom = new System.Windows.Forms.Label();
            this.squareYards = new System.Windows.Forms.Label();
            this.hardwoodCost = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.laborCost = new System.Windows.Forms.Label();
            this.firstRoom = new System.Windows.Forms.Label();
            this.underlayment = new System.Windows.Forms.Label();
            this.maxLengthTextbox = new System.Windows.Forms.TextBox();
            this.underlaymentTextbox = new System.Windows.Forms.TextBox();
            this.firstRoomTextbox = new System.Windows.Forms.TextBox();
            this.hardwoodPriceTextbox = new System.Windows.Forms.TextBox();
            this.calculationButton = new System.Windows.Forms.Button();
            this.underlayCostOutput = new System.Windows.Forms.Label();
            this.hardwoodCostOutput = new System.Windows.Forms.Label();
            this.laborCostOutput = new System.Windows.Forms.Label();
            this.totalCostOutput = new System.Windows.Forms.Label();
            this.squareYardsCostOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EZ-Hardwood Flooring Estimator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // maxWidthTextbox
            // 
            this.maxWidthTextbox.Location = new System.Drawing.Point(297, 32);
            this.maxWidthTextbox.Name = "maxWidthTextbox";
            this.maxWidthTextbox.Size = new System.Drawing.Size(100, 20);
            this.maxWidthTextbox.TabIndex = 1;
            // 
            // underlayCost
            // 
            this.underlayCost.AutoSize = true;
            this.underlayCost.Location = new System.Drawing.Point(156, 351);
            this.underlayCost.Name = "underlayCost";
            this.underlayCost.Size = new System.Drawing.Size(76, 13);
            this.underlayCost.TabIndex = 2;
            this.underlayCost.Text = "Underlay Cost:";
            // 
            // hardwoodPrice
            // 
            this.hardwoodPrice.AutoSize = true;
            this.hardwoodPrice.Location = new System.Drawing.Point(156, 107);
            this.hardwoodPrice.Name = "hardwoodPrice";
            this.hardwoodPrice.Size = new System.Drawing.Size(123, 13);
            this.hardwoodPrice.TabIndex = 3;
            this.hardwoodPrice.Text = "Hardwood Price (sq. yd):";
            // 
            // MaxLengthOfRoom
            // 
            this.MaxLengthOfRoom.AutoSize = true;
            this.MaxLengthOfRoom.Location = new System.Drawing.Point(156, 68);
            this.MaxLengthOfRoom.Name = "MaxLengthOfRoom";
            this.MaxLengthOfRoom.Size = new System.Drawing.Size(124, 13);
            this.MaxLengthOfRoom.TabIndex = 4;
            this.MaxLengthOfRoom.Text = "Max Length of Room (ft):";
            // 
            // maxWidthofRoom
            // 
            this.maxWidthofRoom.AutoSize = true;
            this.maxWidthofRoom.Location = new System.Drawing.Point(156, 35);
            this.maxWidthofRoom.Name = "maxWidthofRoom";
            this.maxWidthofRoom.Size = new System.Drawing.Size(119, 13);
            this.maxWidthofRoom.TabIndex = 5;
            this.maxWidthofRoom.Text = "Max Width of Room (ft):";
            // 
            // squareYards
            // 
            this.squareYards.AutoSize = true;
            this.squareYards.Location = new System.Drawing.Point(161, 269);
            this.squareYards.Name = "squareYards";
            this.squareYards.Size = new System.Drawing.Size(56, 13);
            this.squareYards.TabIndex = 6;
            this.squareYards.Text = "Sq. Yards:";
            // 
            // hardwoodCost
            // 
            this.hardwoodCost.AutoSize = true;
            this.hardwoodCost.Location = new System.Drawing.Point(156, 303);
            this.hardwoodCost.Name = "hardwoodCost";
            this.hardwoodCost.Size = new System.Drawing.Size(83, 13);
            this.hardwoodCost.TabIndex = 7;
            this.hardwoodCost.Text = "Hardwood Cost:";
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.Location = new System.Drawing.Point(156, 465);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(58, 13);
            this.totalCost.TabIndex = 8;
            this.totalCost.Text = "Total Cost:";
            // 
            // laborCost
            // 
            this.laborCost.AutoSize = true;
            this.laborCost.Location = new System.Drawing.Point(156, 411);
            this.laborCost.Name = "laborCost";
            this.laborCost.Size = new System.Drawing.Size(61, 13);
            this.laborCost.TabIndex = 9;
            this.laborCost.Text = "Labor Cost:";
            // 
            // firstRoom
            // 
            this.firstRoom.AutoSize = true;
            this.firstRoom.Location = new System.Drawing.Point(156, 194);
            this.firstRoom.Name = "firstRoom";
            this.firstRoom.Size = new System.Drawing.Size(92, 26);
            this.firstRoom.TabIndex = 10;
            this.firstRoom.Text = "First Room:\r\n(1 = YES. 0 = NO)\r\n";
            // 
            // underlayment
            // 
            this.underlayment.AutoSize = true;
            this.underlayment.Location = new System.Drawing.Point(156, 149);
            this.underlayment.Name = "underlayment";
            this.underlayment.Size = new System.Drawing.Size(89, 26);
            this.underlayment.TabIndex = 11;
            this.underlayment.Text = "Underlayment:\r\n(1 = Yes. 0 = NO)\r\n";
            // 
            // maxLengthTextbox
            // 
            this.maxLengthTextbox.Location = new System.Drawing.Point(297, 68);
            this.maxLengthTextbox.Name = "maxLengthTextbox";
            this.maxLengthTextbox.Size = new System.Drawing.Size(100, 20);
            this.maxLengthTextbox.TabIndex = 13;
            // 
            // underlaymentTextbox
            // 
            this.underlaymentTextbox.Location = new System.Drawing.Point(297, 155);
            this.underlaymentTextbox.Name = "underlaymentTextbox";
            this.underlaymentTextbox.Size = new System.Drawing.Size(100, 20);
            this.underlaymentTextbox.TabIndex = 14;
            // 
            // firstRoomTextbox
            // 
            this.firstRoomTextbox.Location = new System.Drawing.Point(297, 213);
            this.firstRoomTextbox.Name = "firstRoomTextbox";
            this.firstRoomTextbox.Size = new System.Drawing.Size(100, 20);
            this.firstRoomTextbox.TabIndex = 15;
            // 
            // hardwoodPriceTextbox
            // 
            this.hardwoodPriceTextbox.Location = new System.Drawing.Point(297, 107);
            this.hardwoodPriceTextbox.Name = "hardwoodPriceTextbox";
            this.hardwoodPriceTextbox.Size = new System.Drawing.Size(100, 20);
            this.hardwoodPriceTextbox.TabIndex = 16;
            // 
            // calculationButton
            // 
            this.calculationButton.Location = new System.Drawing.Point(199, 495);
            this.calculationButton.Name = "calculationButton";
            this.calculationButton.Size = new System.Drawing.Size(165, 23);
            this.calculationButton.TabIndex = 23;
            this.calculationButton.Text = "Calculate Estimate";
            this.calculationButton.UseVisualStyleBackColor = true;
            this.calculationButton.Click += new System.EventHandler(this.calculationButton_Click);
            // 
            // underlayCostOutput
            // 
            this.underlayCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.underlayCostOutput.Location = new System.Drawing.Point(297, 341);
            this.underlayCostOutput.Name = "underlayCostOutput";
            this.underlayCostOutput.Size = new System.Drawing.Size(100, 23);
            this.underlayCostOutput.TabIndex = 24;
            // 
            // hardwoodCostOutput
            // 
            this.hardwoodCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hardwoodCostOutput.Location = new System.Drawing.Point(297, 302);
            this.hardwoodCostOutput.Name = "hardwoodCostOutput";
            this.hardwoodCostOutput.Size = new System.Drawing.Size(100, 23);
            this.hardwoodCostOutput.TabIndex = 25;
            // 
            // laborCostOutput
            // 
            this.laborCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborCostOutput.Location = new System.Drawing.Point(297, 401);
            this.laborCostOutput.Name = "laborCostOutput";
            this.laborCostOutput.Size = new System.Drawing.Size(100, 23);
            this.laborCostOutput.TabIndex = 26;
            // 
            // totalCostOutput
            // 
            this.totalCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostOutput.Location = new System.Drawing.Point(297, 464);
            this.totalCostOutput.Name = "totalCostOutput";
            this.totalCostOutput.Size = new System.Drawing.Size(100, 23);
            this.totalCostOutput.TabIndex = 27;
            // 
            // squareYardsCostOutput
            // 
            this.squareYardsCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.squareYardsCostOutput.Location = new System.Drawing.Point(297, 259);
            this.squareYardsCostOutput.Name = "squareYardsCostOutput";
            this.squareYardsCostOutput.Size = new System.Drawing.Size(100, 23);
            this.squareYardsCostOutput.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 530);
            this.Controls.Add(this.squareYardsCostOutput);
            this.Controls.Add(this.totalCostOutput);
            this.Controls.Add(this.laborCostOutput);
            this.Controls.Add(this.hardwoodCostOutput);
            this.Controls.Add(this.underlayCostOutput);
            this.Controls.Add(this.calculationButton);
            this.Controls.Add(this.hardwoodPriceTextbox);
            this.Controls.Add(this.firstRoomTextbox);
            this.Controls.Add(this.underlaymentTextbox);
            this.Controls.Add(this.maxLengthTextbox);
            this.Controls.Add(this.underlayment);
            this.Controls.Add(this.firstRoom);
            this.Controls.Add(this.laborCost);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.hardwoodCost);
            this.Controls.Add(this.squareYards);
            this.Controls.Add(this.maxWidthofRoom);
            this.Controls.Add(this.MaxLengthOfRoom);
            this.Controls.Add(this.hardwoodPrice);
            this.Controls.Add(this.underlayCost);
            this.Controls.Add(this.maxWidthTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxWidthTextbox;
        private System.Windows.Forms.Label underlayCost;
        private System.Windows.Forms.Label hardwoodPrice;
        private System.Windows.Forms.Label MaxLengthOfRoom;
        private System.Windows.Forms.Label maxWidthofRoom;
        private System.Windows.Forms.Label squareYards;
        private System.Windows.Forms.Label hardwoodCost;
        private System.Windows.Forms.Label totalCost;
        private System.Windows.Forms.Label laborCost;
        private System.Windows.Forms.Label firstRoom;
        private System.Windows.Forms.Label underlayment;
        private System.Windows.Forms.TextBox maxLengthTextbox;
        private System.Windows.Forms.TextBox underlaymentTextbox;
        private System.Windows.Forms.TextBox firstRoomTextbox;
        private System.Windows.Forms.TextBox hardwoodPriceTextbox;
        private System.Windows.Forms.Button calculationButton;
        private System.Windows.Forms.Label underlayCostOutput;
        private System.Windows.Forms.Label hardwoodCostOutput;
        private System.Windows.Forms.Label laborCostOutput;
        private System.Windows.Forms.Label totalCostOutput;
        private System.Windows.Forms.Label squareYardsCostOutput;
    }
}

