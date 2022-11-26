namespace alarm
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.n_hours = new System.Windows.Forms.NumericUpDown();
            this.n_minuts = new System.Windows.Forms.NumericUpDown();
            this.n_seconde = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.n_hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_minuts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_seconde)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(272, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "System Time";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // n_hours
            // 
            this.n_hours.Location = new System.Drawing.Point(152, 81);
            this.n_hours.Name = "n_hours";
            this.n_hours.Size = new System.Drawing.Size(76, 22);
            this.n_hours.TabIndex = 2;
            this.n_hours.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // n_minuts
            // 
            this.n_minuts.Location = new System.Drawing.Point(272, 81);
            this.n_minuts.Name = "n_minuts";
            this.n_minuts.Size = new System.Drawing.Size(74, 22);
            this.n_minuts.TabIndex = 3;
            // 
            // n_seconde
            // 
            this.n_seconde.Location = new System.Drawing.Point(398, 81);
            this.n_seconde.Name = "n_seconde";
            this.n_seconde.Size = new System.Drawing.Size(79, 22);
            this.n_seconde.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 444);
            this.Controls.Add(this.n_seconde);
            this.Controls.Add(this.n_minuts);
            this.Controls.Add(this.n_hours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.n_hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_minuts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_seconde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown n_hours;
        private System.Windows.Forms.NumericUpDown n_minuts;
        private System.Windows.Forms.NumericUpDown n_seconde;
        private System.Windows.Forms.Timer timer1;
    }
}

