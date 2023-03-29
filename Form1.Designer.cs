namespace ProvaAPrendermi
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
            btnNO=new Button();
            btnSI=new Button();
            lblMessaggio=new Label();
            SuspendLayout();
            // 
            // btnNO
            // 
            btnNO.Font=new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnNO.ImageAlign=ContentAlignment.BottomRight;
            btnNO.Location=new Point(88, 181);
            btnNO.Name="btnNO";
            btnNO.Size=new Size(184, 80);
            btnNO.TabIndex=1;
            btnNO.Text="NO";
            btnNO.UseVisualStyleBackColor=true;
            btnNO.Click+=btnNO_Click;
            btnNO.MouseMove+=btnNO_MouseMove;
            // 
            // btnSI
            // 
            btnSI.Font=new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnSI.ImageAlign=ContentAlignment.BottomRight;
            btnSI.Location=new Point(539, 181);
            btnSI.Name="btnSI";
            btnSI.Size=new Size(184, 80);
            btnSI.TabIndex=0;
            btnSI.Text="SI";
            btnSI.UseVisualStyleBackColor=true;
            // 
            // lblMessaggio
            // 
            lblMessaggio.AutoSize=true;
            lblMessaggio.BackColor=Color.Transparent;
            lblMessaggio.Font=new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessaggio.Location=new Point(88, 54);
            lblMessaggio.Name="lblMessaggio";
            lblMessaggio.Size=new Size(635, 62);
            lblMessaggio.TabIndex=2;
            lblMessaggio.Text="Ti piace il corso PON coding?";
            // 
            // Form1
            // 
            AcceptButton=btnSI;
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.ActiveCaption;
            CancelButton=btnNO;
            ClientSize=new Size(813, 326);
            Controls.Add(btnNO);
            Controls.Add(lblMessaggio);
            Controls.Add(btnSI);
            Name="Form1";
            Text="Prova a prendermi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNO;
        private Button btnSI;
        private Label lblMessaggio;
    }
}