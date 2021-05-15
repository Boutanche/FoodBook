
using System.Windows.Forms;

namespace ClientDesktop
{
    partial class DishForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DishForm));
            this.tableLayoutPanel_background = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_ingredients = new System.Windows.Forms.DataGridView();
            this.AddIngredients = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel_background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ingredients)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_background
            // 
            this.tableLayoutPanel_background.ColumnCount = 2;
            this.tableLayoutPanel_background.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_background.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_background.Controls.Add(this.dataGridView_ingredients, 1, 1);
            this.tableLayoutPanel_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_background.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_background.Name = "tableLayoutPanel_background";
            this.tableLayoutPanel_background.RowCount = 2;
            this.tableLayoutPanel_background.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.555555F));
            this.tableLayoutPanel_background.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.44444F));
            this.tableLayoutPanel_background.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_background.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel_background.TabIndex = 0;
            // 
            // dataGridView_ingredients
            // 
            this.dataGridView_ingredients.AllowUserToAddRows = false;
            this.dataGridView_ingredients.AllowUserToDeleteRows = false;
            this.dataGridView_ingredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ingredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ingredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddIngredients});
            this.dataGridView_ingredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ingredients.Location = new System.Drawing.Point(403, 46);
            this.dataGridView_ingredients.Name = "dataGridView_ingredients";
            this.dataGridView_ingredients.ReadOnly = true;
            this.dataGridView_ingredients.RowTemplate.Height = 25;
            this.dataGridView_ingredients.Size = new System.Drawing.Size(394, 401);
            this.dataGridView_ingredients.TabIndex = 0;
            // 
            // AddIngredients
            // 
            this.AddIngredients.HeaderText = "Ajouter au plat";
            this.AddIngredients.Name = "AddIngredients";
            this.AddIngredients.ReadOnly = true;
            this.AddIngredients.Text = "+";
            this.AddIngredients.ToolTipText = "Ici pour ajouter";
            this.AddIngredients.UseColumnTextForButtonValue = true;
            // 
            // DishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel_background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DishForm";
            this.Text = "Créer une recette";
            this.tableLayoutPanel_background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ingredients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_background;
        private System.Windows.Forms.DataGridView dataGridView_ingredients;
        private DataGridViewButtonColumn AddIngredients;
    }
}