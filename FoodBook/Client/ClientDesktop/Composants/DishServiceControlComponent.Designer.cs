
namespace ClientDesktop.Composants
{
    partial class DishServiceControlComponent
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.DishComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel_BtnS1D1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.ModifyBtn = new System.Windows.Forms.Button();
            this.MainTable.SuspendLayout();
            this.tableLayoutPanel_BtnS1D1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 1;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.Controls.Add(this.DishComboBox, 0, 0);
            this.MainTable.Controls.Add(this.tableLayoutPanel_BtnS1D1, 0, 1);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 2;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.Size = new System.Drawing.Size(150, 150);
            this.MainTable.TabIndex = 1;
            // 
            // DishComboBox
            // 
            this.DishComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DishComboBox.FormattingEnabled = true;
            this.DishComboBox.Location = new System.Drawing.Point(3, 26);
            this.DishComboBox.Name = "DishComboBox";
            this.DishComboBox.Size = new System.Drawing.Size(144, 23);
            this.DishComboBox.TabIndex = 0;
            // 
            // tableLayoutPanel_BtnS1D1
            // 
            this.tableLayoutPanel_BtnS1D1.ColumnCount = 3;
            this.tableLayoutPanel_BtnS1D1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_BtnS1D1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_BtnS1D1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_BtnS1D1.Controls.Add(this.AddBtn, 0, 0);
            this.tableLayoutPanel_BtnS1D1.Controls.Add(this.DelBtn, 1, 0);
            this.tableLayoutPanel_BtnS1D1.Controls.Add(this.ModifyBtn, 2, 0);
            this.tableLayoutPanel_BtnS1D1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_BtnS1D1.Location = new System.Drawing.Point(3, 78);
            this.tableLayoutPanel_BtnS1D1.Name = "tableLayoutPanel_BtnS1D1";
            this.tableLayoutPanel_BtnS1D1.RowCount = 1;
            this.tableLayoutPanel_BtnS1D1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_BtnS1D1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel_BtnS1D1.Size = new System.Drawing.Size(144, 69);
            this.tableLayoutPanel_BtnS1D1.TabIndex = 1;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddBtn.Location = new System.Drawing.Point(3, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(41, 63);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "+";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.LightCoral;
            this.DelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelBtn.Enabled = false;
            this.DelBtn.Location = new System.Drawing.Point(50, 3);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(41, 63);
            this.DelBtn.TabIndex = 1;
            this.DelBtn.Text = "x";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ModifyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModifyBtn.Location = new System.Drawing.Point(97, 3);
            this.ModifyBtn.Name = "ModifyBtn";
            this.ModifyBtn.Size = new System.Drawing.Size(44, 63);
            this.ModifyBtn.TabIndex = 2;
            this.ModifyBtn.Text = "...";
            this.ModifyBtn.UseVisualStyleBackColor = false;
            this.ModifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
            // 
            // DishServiceControlComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTable);
            this.Name = "DishServiceControlComponent";
            this.MainTable.ResumeLayout(false);
            this.tableLayoutPanel_BtnS1D1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.ComboBox DishComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_BtnS1D1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button ModifyBtn;
    }
}
