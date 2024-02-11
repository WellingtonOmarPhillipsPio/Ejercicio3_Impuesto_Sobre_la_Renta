namespace Impuesto_Sobre_Renta
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
            Pago_Hora=new Label();
            Horas_Trabajadas=new Label();
            AFP=new Label();
            SFS=new Label();
            Sueldo_Bruto=new Label();
            Total_Descuento=new Label();
            Sueldo_Neto=new Label();
            btn_Calcular=new Button();
            btn_Limpiar=new Button();
            btn_Salir=new Button();
            txt_Pago_Hora=new TextBox();
            txt_Sueldo_Bruto=new TextBox();
            txt_Sueldo_Neto=new TextBox();
            txt_Total_Descuento=new TextBox();
            txt_Horas_Trabajadas=new TextBox();
            txt_AFP=new TextBox();
            txt_SFS=new TextBox();
            Sueldo_Anual=new Label();
            lSR=new Label();
            txt_ISR=new TextBox();
            txt_Sueldo_Anual=new TextBox();
            label1=new Label();
            SuspendLayout();
            // 
            // Pago_Hora
            // 
            Pago_Hora.AutoSize=true;
            Pago_Hora.Font=new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Pago_Hora.Location=new Point(247, 49);
            Pago_Hora.Name="Pago_Hora";
            Pago_Hora.Size=new Size(68, 15);
            Pago_Hora.TabIndex=0;
            Pago_Hora.Text="Pago_Hora";
            // 
            // Horas_Trabajadas
            // 
            Horas_Trabajadas.AutoSize=true;
            Horas_Trabajadas.Font=new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Horas_Trabajadas.Location=new Point(236, 115);
            Horas_Trabajadas.Name="Horas_Trabajadas";
            Horas_Trabajadas.Size=new Size(106, 15);
            Horas_Trabajadas.TabIndex=1;
            Horas_Trabajadas.Text="Horas_Trabajadas";
            // 
            // AFP
            // 
            AFP.AutoSize=true;
            AFP.Font=new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AFP.Location=new Point(247, 192);
            AFP.Name="AFP";
            AFP.Size=new Size(31, 15);
            AFP.TabIndex=2;
            AFP.Text="AFP";
            // 
            // SFS
            // 
            SFS.AutoSize=true;
            SFS.Font=new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SFS.Location=new Point(247, 250);
            SFS.Name="SFS";
            SFS.Size=new Size(30, 15);
            SFS.TabIndex=3;
            SFS.Text="SFS";
            // 
            // Sueldo_Bruto
            // 
            Sueldo_Bruto.AutoSize=true;
            Sueldo_Bruto.Font=new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Sueldo_Bruto.Location=new Point(247, 157);
            Sueldo_Bruto.Name="Sueldo_Bruto";
            Sueldo_Bruto.Size=new Size(83, 15);
            Sueldo_Bruto.TabIndex=4;
            Sueldo_Bruto.Text="Sueldo_Bruto";
            // 
            // Total_Descuento
            // 
            Total_Descuento.AutoSize=true;
            Total_Descuento.Font=new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Total_Descuento.Location=new Point(247, 295);
            Total_Descuento.Name="Total_Descuento";
            Total_Descuento.Size=new Size(98, 15);
            Total_Descuento.TabIndex=5;
            Total_Descuento.Text="Total_Descuento";
            // 
            // Sueldo_Neto
            // 
            Sueldo_Neto.AutoSize=true;
            Sueldo_Neto.Font=new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Sueldo_Neto.Location=new Point(247, 345);
            Sueldo_Neto.Name="Sueldo_Neto";
            Sueldo_Neto.Size=new Size(76, 15);
            Sueldo_Neto.TabIndex=6;
            Sueldo_Neto.Text="Sueldo_Neto";
            // 
            // btn_Calcular
            // 
            btn_Calcular.BackColor=Color.LightSkyBlue;
            btn_Calcular.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Calcular.Location=new Point(609, 170);
            btn_Calcular.Name="btn_Calcular";
            btn_Calcular.Size=new Size(118, 30);
            btn_Calcular.TabIndex=7;
            btn_Calcular.Text="Calcular";
            btn_Calcular.UseVisualStyleBackColor=false;
            btn_Calcular.Click+=btn_Calcular_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor=Color.LightSkyBlue;
            btn_Limpiar.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Limpiar.Location=new Point(609, 232);
            btn_Limpiar.Name="btn_Limpiar";
            btn_Limpiar.Size=new Size(118, 30);
            btn_Limpiar.TabIndex=8;
            btn_Limpiar.Text="Limpiar";
            btn_Limpiar.UseVisualStyleBackColor=false;
            btn_Limpiar.Click+=btn_Limpiar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor=Color.LightSkyBlue;
            btn_Salir.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Salir.Location=new Point(609, 288);
            btn_Salir.Name="btn_Salir";
            btn_Salir.Size=new Size(118, 30);
            btn_Salir.TabIndex=9;
            btn_Salir.Text="Salir";
            btn_Salir.UseVisualStyleBackColor=false;
            btn_Salir.Click+=btn_Salir_Click;
            // 
            // txt_Pago_Hora
            // 
            txt_Pago_Hora.Font=new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Pago_Hora.Location=new Point(363, 46);
            txt_Pago_Hora.Name="txt_Pago_Hora";
            txt_Pago_Hora.Size=new Size(100, 22);
            txt_Pago_Hora.TabIndex=10;
            // 
            // txt_Sueldo_Bruto
            // 
            txt_Sueldo_Bruto.Font=new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Sueldo_Bruto.Location=new Point(363, 151);
            txt_Sueldo_Bruto.Name="txt_Sueldo_Bruto";
            txt_Sueldo_Bruto.Size=new Size(100, 22);
            txt_Sueldo_Bruto.TabIndex=11;
            // 
            // txt_Sueldo_Neto
            // 
            txt_Sueldo_Neto.Font=new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Sueldo_Neto.Location=new Point(363, 342);
            txt_Sueldo_Neto.Name="txt_Sueldo_Neto";
            txt_Sueldo_Neto.Size=new Size(100, 22);
            txt_Sueldo_Neto.TabIndex=12;
            // 
            // txt_Total_Descuento
            // 
            txt_Total_Descuento.Font=new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Total_Descuento.Location=new Point(363, 292);
            txt_Total_Descuento.Name="txt_Total_Descuento";
            txt_Total_Descuento.Size=new Size(100, 22);
            txt_Total_Descuento.TabIndex=13;
            // 
            // txt_Horas_Trabajadas
            // 
            txt_Horas_Trabajadas.Font=new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Horas_Trabajadas.Location=new Point(363, 104);
            txt_Horas_Trabajadas.Name="txt_Horas_Trabajadas";
            txt_Horas_Trabajadas.Size=new Size(100, 22);
            txt_Horas_Trabajadas.TabIndex=14;
            // 
            // txt_AFP
            // 
            txt_AFP.Font=new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_AFP.Location=new Point(363, 200);
            txt_AFP.Name="txt_AFP";
            txt_AFP.Size=new Size(100, 22);
            txt_AFP.TabIndex=15;
            // 
            // txt_SFS
            // 
            txt_SFS.Font=new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_SFS.Location=new Point(363, 247);
            txt_SFS.Name="txt_SFS";
            txt_SFS.Size=new Size(100, 22);
            txt_SFS.TabIndex=16;
            // 
            // Sueldo_Anual
            // 
            Sueldo_Anual.AutoSize=true;
            Sueldo_Anual.Font=new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Sueldo_Anual.Location=new Point(247, 387);
            Sueldo_Anual.Name="Sueldo_Anual";
            Sueldo_Anual.Size=new Size(84, 15);
            Sueldo_Anual.TabIndex=17;
            Sueldo_Anual.Text="Sueldo_Anual";
            // 
            // lSR
            // 
            lSR.AutoSize=true;
            lSR.Font=new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lSR.Location=new Point(252, 426);
            lSR.Name="lSR";
            lSR.Size=new Size(28, 15);
            lSR.TabIndex=18;
            lSR.Text="ISR";
            // 
            // txt_ISR
            // 
            txt_ISR.Font=new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_ISR.Location=new Point(363, 426);
            txt_ISR.Name="txt_ISR";
            txt_ISR.Size=new Size(100, 22);
            txt_ISR.TabIndex=19;
            // 
            // txt_Sueldo_Anual
            // 
            txt_Sueldo_Anual.Font=new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Sueldo_Anual.Location=new Point(363, 384);
            txt_Sueldo_Anual.Name="txt_Sueldo_Anual";
            txt_Sueldo_Anual.Size=new Size(100, 22);
            txt_Sueldo_Anual.TabIndex=20;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Impact", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(299, 11);
            label1.Name="label1";
            label1.Size=new Size(311, 29);
            label1.TabIndex=21;
            label1.Text="IMPUESTO_SOBRE_LA_RENTA";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txt_Sueldo_Anual);
            Controls.Add(txt_ISR);
            Controls.Add(lSR);
            Controls.Add(Sueldo_Anual);
            Controls.Add(txt_SFS);
            Controls.Add(txt_AFP);
            Controls.Add(txt_Horas_Trabajadas);
            Controls.Add(txt_Total_Descuento);
            Controls.Add(txt_Sueldo_Neto);
            Controls.Add(txt_Sueldo_Bruto);
            Controls.Add(txt_Pago_Hora);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Calcular);
            Controls.Add(Sueldo_Neto);
            Controls.Add(Total_Descuento);
            Controls.Add(Sueldo_Bruto);
            Controls.Add(SFS);
            Controls.Add(AFP);
            Controls.Add(Horas_Trabajadas);
            Controls.Add(Pago_Hora);
            Name="Form1";
            Text="Form1";
            Load+=Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Pago_Hora;
        private Label Horas_Trabajadas;
        private Label AFP;
        private Label SFS;
        private Label Sueldo_Bruto;
        private Label Total_Descuento;
        private Label Sueldo_Neto;
        private Button btn_Calcular;
        private Button btn_Limpiar;
        private Button btn_Salir;
        private TextBox txt_Pago_Hora;
        private TextBox txt_Sueldo_Bruto;
        private TextBox txt_Sueldo_Neto;
        private TextBox txt_Total_Descuento;
        private TextBox txt_Horas_Trabajadas;
        private TextBox txt_AFP;
        private TextBox txt_SFS;
        private Label Sueldo_Anual;
        private Label lSR;
        private TextBox txt_ISR;
        private TextBox txt_Sueldo_Anual;
        private Label label1;
    }
}