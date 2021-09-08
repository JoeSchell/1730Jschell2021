
namespace Jschell1c1
{
    partial class Jschell1c1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jschell1c1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtHotdogs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHotdogSubtotal = new System.Windows.Forms.TextBox();
            this.txtHamburgersSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHamburgers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtPretax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHotdogs
            // 
            resources.ApplyResources(this.txtHotdogs, "txtHotdogs");
            this.txtHotdogs.Name = "txtHotdogs";
            this.txtHotdogs.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtHotdogSubtotal
            // 
            resources.ApplyResources(this.txtHotdogSubtotal, "txtHotdogSubtotal");
            this.txtHotdogSubtotal.Name = "txtHotdogSubtotal";
            this.txtHotdogSubtotal.ReadOnly = true;
            this.txtHotdogSubtotal.TabStop = false;
            // 
            // txtHamburgersSubtotal
            // 
            resources.ApplyResources(this.txtHamburgersSubtotal, "txtHamburgersSubtotal");
            this.txtHamburgersSubtotal.Name = "txtHamburgersSubtotal";
            this.txtHamburgersSubtotal.ReadOnly = true;
            this.txtHamburgersSubtotal.TabStop = false;
            this.txtHamburgersSubtotal.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtHamburgers
            // 
            resources.ApplyResources(this.txtHamburgers, "txtHamburgers");
            this.txtHamburgers.Name = "txtHamburgers";
            this.txtHamburgers.TextChanged += new System.EventHandler(this.Hamburgerstxt_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnCalculate
            // 
            resources.ApplyResources(this.btnCalculate, "btnCalculate");
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtTax
            // 
            resources.ApplyResources(this.txtTax, "txtTax");
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.TabStop = false;
            this.txtTax.TextChanged += new System.EventHandler(this.txtTax_TextChanged);
            // 
            // txtPretax
            // 
            resources.ApplyResources(this.txtPretax, "txtPretax");
            this.txtPretax.Name = "txtPretax";
            this.txtPretax.ReadOnly = true;
            this.txtPretax.TabStop = false;
            this.txtPretax.TextChanged += new System.EventHandler(this.txtPretax_TextChanged);
            // 
            // txtTotal
            // 
            resources.ApplyResources(this.txtTotal, "txtTotal");
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Jschell1c1
            // 
            this.AcceptButton = this.btnCalculate;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPretax);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtHamburgersSubtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHamburgers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHotdogSubtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHotdogs);
            this.Controls.Add(this.label1);
            this.Name = "Jschell1c1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHotdogs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHotdogSubtotal;
        private System.Windows.Forms.TextBox txtHamburgersSubtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHamburgers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtPretax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

