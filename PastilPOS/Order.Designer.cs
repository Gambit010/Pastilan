namespace PastilPOS
{
    partial class Order
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nuggetsQuantity = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.eggQuantity = new System.Windows.Forms.NumericUpDown();
            this.lumpiaQuantity = new System.Windows.Forms.NumericUpDown();
            this.extrariceQuantity = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.addOrder = new System.Windows.Forms.Button();
            this.proceedToCheckout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nuggetsQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eggQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lumpiaQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extrariceQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(75, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "C1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(210, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "C2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(75, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "B1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(210, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "B2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // B2
            // 
            this.B2.BackgroundImage = global::PastilPOS.Properties.Resources.Emerging_food_and_beverage_brands_participate_in_7_Eleven_program1;
            this.B2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B2.Location = new System.Drawing.Point(187, 194);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(112, 102);
            this.B2.TabIndex = 3;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B1
            // 
            this.B1.BackgroundImage = global::PastilPOS.Properties.Resources.fsdfs;
            this.B1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B1.Location = new System.Drawing.Point(54, 194);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(112, 102);
            this.B1.TabIndex = 2;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // C2
            // 
            this.C2.BackgroundImage = global::PastilPOS.Properties.Resources.hello_kitty___;
            this.C2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.C2.Location = new System.Drawing.Point(187, 41);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(112, 102);
            this.C2.TabIndex = 1;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.C2_Click);
            // 
            // C1
            // 
            this.C1.BackgroundImage = global::PastilPOS.Properties.Resources._7111;
            this.C1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.C1.Location = new System.Drawing.Point(54, 40);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(112, 102);
            this.C1.TabIndex = 0;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.C1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Add ons";
            // 
            // nuggetsQuantity
            // 
            this.nuggetsQuantity.Enabled = false;
            this.nuggetsQuantity.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nuggetsQuantity.Location = new System.Drawing.Point(435, 71);
            this.nuggetsQuantity.Name = "nuggetsQuantity";
            this.nuggetsQuantity.Size = new System.Drawing.Size(135, 22);
            this.nuggetsQuantity.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(354, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nuggets";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(354, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Egg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(354, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Lumpia";
            // 
            // eggQuantity
            // 
            this.eggQuantity.Enabled = false;
            this.eggQuantity.Location = new System.Drawing.Point(435, 158);
            this.eggQuantity.Name = "eggQuantity";
            this.eggQuantity.Size = new System.Drawing.Size(135, 22);
            this.eggQuantity.TabIndex = 13;
            // 
            // lumpiaQuantity
            // 
            this.lumpiaQuantity.Enabled = false;
            this.lumpiaQuantity.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.lumpiaQuantity.Location = new System.Drawing.Point(435, 114);
            this.lumpiaQuantity.Name = "lumpiaQuantity";
            this.lumpiaQuantity.Size = new System.Drawing.Size(135, 22);
            this.lumpiaQuantity.TabIndex = 14;
            // 
            // extrariceQuantity
            // 
            this.extrariceQuantity.Location = new System.Drawing.Point(435, 200);
            this.extrariceQuantity.Name = "extrariceQuantity";
            this.extrariceQuantity.Size = new System.Drawing.Size(135, 22);
            this.extrariceQuantity.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(350, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Extra rice";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(353, 250);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(77, 29);
            this.back.TabIndex = 17;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // addOrder
            // 
            this.addOrder.Location = new System.Drawing.Point(462, 250);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(107, 28);
            this.addOrder.TabIndex = 18;
            this.addOrder.Text = "Add order";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // proceedToCheckout
            // 
            this.proceedToCheckout.Location = new System.Drawing.Point(404, 305);
            this.proceedToCheckout.Name = "proceedToCheckout";
            this.proceedToCheckout.Size = new System.Drawing.Size(130, 35);
            this.proceedToCheckout.TabIndex = 19;
            this.proceedToCheckout.Text = "Proceed checkout";
            this.proceedToCheckout.UseVisualStyleBackColor = true;
            this.proceedToCheckout.Click += new System.EventHandler(this.proceedToCheckout_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.proceedToCheckout);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.extrariceQuantity);
            this.Controls.Add(this.lumpiaQuantity);
            this.Controls.Add(this.eggQuantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nuggetsQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Name = "Order";
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.nuggetsQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eggQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lumpiaQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extrariceQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nuggetsQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown eggQuantity;
        private System.Windows.Forms.NumericUpDown lumpiaQuantity;
        private System.Windows.Forms.NumericUpDown extrariceQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.Button proceedToCheckout;
    }
}