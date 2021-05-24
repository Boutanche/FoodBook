
namespace ClientDesktop
{
    partial class CreateIngredientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateIngredientForm));
            this.tableLayoutPanel_CreateIngredient = new System.Windows.Forms.TableLayoutPanel();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.textBox_ingredientName = new System.Windows.Forms.TextBox();
            this.textBox_ingredientPrice = new System.Windows.Forms.TextBox();
            this.button_validate = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel_CreateIngredient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_CreateIngredient
            // 
            this.tableLayoutPanel_CreateIngredient.ColumnCount = 3;
            this.tableLayoutPanel_CreateIngredient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.7931F));
            this.tableLayoutPanel_CreateIngredient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.20689F));
            this.tableLayoutPanel_CreateIngredient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_CreateIngredient.Controls.Add(this.label_Name, 1, 0);
            this.tableLayoutPanel_CreateIngredient.Controls.Add(this.label_price, 1, 1);
            this.tableLayoutPanel_CreateIngredient.Controls.Add(this.textBox_ingredientName, 2, 0);
            this.tableLayoutPanel_CreateIngredient.Controls.Add(this.textBox_ingredientPrice, 2, 1);
            this.tableLayoutPanel_CreateIngredient.Controls.Add(this.button_validate, 2, 2);
            this.tableLayoutPanel_CreateIngredient.Controls.Add(this.button_cancel, 1, 2);
            this.tableLayoutPanel_CreateIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_CreateIngredient.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_CreateIngredient.Name = "tableLayoutPanel_CreateIngredient";
            this.tableLayoutPanel_CreateIngredient.RowCount = 3;
            this.tableLayoutPanel_CreateIngredient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_CreateIngredient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_CreateIngredient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_CreateIngredient.Size = new System.Drawing.Size(309, 161);
            this.tableLayoutPanel_CreateIngredient.TabIndex = 0;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(30, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(113, 15);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Nom de l\'ingrédient";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(30, 53);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(106, 15);
            this.label_price.TabIndex = 2;
            this.label_price.Text = "Prix de l\'ingrédient";
            // 
            // textBox_ingredientName
            // 
            this.textBox_ingredientName.Location = new System.Drawing.Point(205, 3);
            this.textBox_ingredientName.Name = "textBox_ingredientName";
            this.textBox_ingredientName.Size = new System.Drawing.Size(100, 23);
            this.textBox_ingredientName.TabIndex = 3;
            // 
            // textBox_ingredientPrice
            // 
            this.textBox_ingredientPrice.Location = new System.Drawing.Point(205, 56);
            this.textBox_ingredientPrice.Name = "textBox_ingredientPrice";
            this.textBox_ingredientPrice.Size = new System.Drawing.Size(100, 23);
            this.textBox_ingredientPrice.TabIndex = 4;
            // 
            // button_validate
            // 
            this.button_validate.BackColor = System.Drawing.Color.PaleGreen;
            this.button_validate.Location = new System.Drawing.Point(205, 109);
            this.button_validate.Name = "button_validate";
            this.button_validate.Size = new System.Drawing.Size(75, 23);
            this.button_validate.TabIndex = 5;
            this.button_validate.Text = "Validation";
            this.button_validate.UseVisualStyleBackColor = false;
            this.button_validate.Click += new System.EventHandler(this.button_validate_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.IndianRed;
            this.button_cancel.Location = new System.Drawing.Point(30, 109);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "Annulation";
            this.button_cancel.UseVisualStyleBackColor = false;
            // 
            // CreateIngredientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 161);
            this.Controls.Add(this.tableLayoutPanel_CreateIngredient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateIngredientForm";
            this.Text = "Ajouter un nouvel ingrédient";
            this.tableLayoutPanel_CreateIngredient.ResumeLayout(false);
            this.tableLayoutPanel_CreateIngredient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_CreateIngredient;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TextBox textBox_ingredientName;
        private System.Windows.Forms.TextBox textBox_ingredientPrice;
        private System.Windows.Forms.Button button_validate;
        private System.Windows.Forms.Button button_cancel;
    }
}