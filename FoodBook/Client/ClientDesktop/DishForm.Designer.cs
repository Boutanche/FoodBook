
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
            this.btn_AddIngredients = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel_IngredientPannel = new System.Windows.Forms.TableLayoutPanel();
            this.button_createIngredient = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.tableLayoutPanel_newDish = new System.Windows.Forms.TableLayoutPanel();
            this.button_ConfirmDish = new System.Windows.Forms.Button();
            this.button_CancelDish = new System.Windows.Forms.Button();
            this.tableLayoutPanel_NewDishInpout = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_PopularityDish = new System.Windows.Forms.TextBox();
            this.label_NameDish = new System.Windows.Forms.Label();
            this.label_TypeOfDish = new System.Windows.Forms.Label();
            this.label_PopularityDish = new System.Windows.Forms.Label();
            this.textBox_NameDish = new System.Windows.Forms.TextBox();
            this.comboBox_TypeDish = new System.Windows.Forms.ComboBox();
            this.dataGridView_DishComposedBy = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel_background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ingredients)).BeginInit();
            this.tableLayoutPanel_IngredientPannel.SuspendLayout();
            this.tableLayoutPanel_newDish.SuspendLayout();
            this.tableLayoutPanel_NewDishInpout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DishComposedBy)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_background
            // 
            this.tableLayoutPanel_background.ColumnCount = 2;
            this.tableLayoutPanel_background.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_background.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_background.Controls.Add(this.dataGridView_ingredients, 1, 1);
            this.tableLayoutPanel_background.Controls.Add(this.tableLayoutPanel_IngredientPannel, 1, 0);
            this.tableLayoutPanel_background.Controls.Add(this.label_Title, 0, 0);
            this.tableLayoutPanel_background.Controls.Add(this.tableLayoutPanel_newDish, 0, 1);
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
            this.btn_AddIngredients});
            this.dataGridView_ingredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ingredients.Location = new System.Drawing.Point(403, 46);
            this.dataGridView_ingredients.Name = "dataGridView_ingredients";
            this.dataGridView_ingredients.ReadOnly = true;
            this.dataGridView_ingredients.RowTemplate.Height = 25;
            this.dataGridView_ingredients.Size = new System.Drawing.Size(394, 401);
            this.dataGridView_ingredients.TabIndex = 0;
            this.dataGridView_ingredients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_ingredients_CellClick);
            // 
            // btn_AddIngredients
            // 
            this.btn_AddIngredients.HeaderText = "Ajouter au plat";
            this.btn_AddIngredients.Name = "btn_AddIngredients";
            this.btn_AddIngredients.ReadOnly = true;
            this.btn_AddIngredients.Text = "+";
            this.btn_AddIngredients.ToolTipText = "Cliquer ici pour ajouter à votre plat";
            this.btn_AddIngredients.UseColumnTextForButtonValue = true;
            // 
            // tableLayoutPanel_IngredientPannel
            // 
            this.tableLayoutPanel_IngredientPannel.ColumnCount = 2;
            this.tableLayoutPanel_IngredientPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_IngredientPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_IngredientPannel.Controls.Add(this.button_createIngredient, 0, 1);
            this.tableLayoutPanel_IngredientPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_IngredientPannel.Location = new System.Drawing.Point(403, 3);
            this.tableLayoutPanel_IngredientPannel.Name = "tableLayoutPanel_IngredientPannel";
            this.tableLayoutPanel_IngredientPannel.RowCount = 2;
            this.tableLayoutPanel_IngredientPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.62162F));
            this.tableLayoutPanel_IngredientPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.37838F));
            this.tableLayoutPanel_IngredientPannel.Size = new System.Drawing.Size(394, 37);
            this.tableLayoutPanel_IngredientPannel.TabIndex = 1;
            // 
            // button_createIngredient
            // 
            this.button_createIngredient.BackColor = System.Drawing.Color.PaleGreen;
            this.button_createIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_createIngredient.Location = new System.Drawing.Point(3, 10);
            this.button_createIngredient.Name = "button_createIngredient";
            this.button_createIngredient.Size = new System.Drawing.Size(191, 24);
            this.button_createIngredient.TabIndex = 0;
            this.button_createIngredient.Text = "Ajouter un ingrédient à la liste";
            this.button_createIngredient.UseVisualStyleBackColor = false;
            this.button_createIngredient.Click += new System.EventHandler(this.Button_createIngredient_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Title.Font = new System.Drawing.Font("Gotham Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Title.ForeColor = System.Drawing.Color.Orange;
            this.label_Title.Location = new System.Drawing.Point(3, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(394, 43);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Créer un nouveau plat :";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_newDish
            // 
            this.tableLayoutPanel_newDish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_newDish.ColumnCount = 1;
            this.tableLayoutPanel_newDish.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_newDish.Controls.Add(this.button_ConfirmDish, 0, 2);
            this.tableLayoutPanel_newDish.Controls.Add(this.button_CancelDish, 0, 3);
            this.tableLayoutPanel_newDish.Controls.Add(this.tableLayoutPanel_NewDishInpout, 0, 0);
            this.tableLayoutPanel_newDish.Controls.Add(this.dataGridView_DishComposedBy, 0, 1);
            this.tableLayoutPanel_newDish.Location = new System.Drawing.Point(3, 46);
            this.tableLayoutPanel_newDish.Name = "tableLayoutPanel_newDish";
            this.tableLayoutPanel_newDish.RowCount = 4;
            this.tableLayoutPanel_newDish.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_newDish.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_newDish.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_newDish.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel_newDish.Size = new System.Drawing.Size(394, 401);
            this.tableLayoutPanel_newDish.TabIndex = 3;
            // 
            // button_ConfirmDish
            // 
            this.button_ConfirmDish.BackColor = System.Drawing.Color.PaleGreen;
            this.button_ConfirmDish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ConfirmDish.Location = new System.Drawing.Point(3, 333);
            this.button_ConfirmDish.Name = "button_ConfirmDish";
            this.button_ConfirmDish.Size = new System.Drawing.Size(388, 34);
            this.button_ConfirmDish.TabIndex = 0;
            this.button_ConfirmDish.Text = "Confirmer création du plat";
            this.button_ConfirmDish.UseVisualStyleBackColor = false;
            this.button_ConfirmDish.Click += new System.EventHandler(this.Button_ConfirmDish_ClickAsync);
            // 
            // button_CancelDish
            // 
            this.button_CancelDish.BackColor = System.Drawing.Color.IndianRed;
            this.button_CancelDish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_CancelDish.Location = new System.Drawing.Point(3, 373);
            this.button_CancelDish.Name = "button_CancelDish";
            this.button_CancelDish.Size = new System.Drawing.Size(388, 25);
            this.button_CancelDish.TabIndex = 1;
            this.button_CancelDish.Text = "Annuler";
            this.button_CancelDish.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel_NewDishInpout
            // 
            this.tableLayoutPanel_NewDishInpout.ColumnCount = 2;
            this.tableLayoutPanel_NewDishInpout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_NewDishInpout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_NewDishInpout.Controls.Add(this.textBox_PopularityDish, 1, 2);
            this.tableLayoutPanel_NewDishInpout.Controls.Add(this.label_NameDish, 0, 0);
            this.tableLayoutPanel_NewDishInpout.Controls.Add(this.label_TypeOfDish, 0, 1);
            this.tableLayoutPanel_NewDishInpout.Controls.Add(this.label_PopularityDish, 0, 2);
            this.tableLayoutPanel_NewDishInpout.Controls.Add(this.textBox_NameDish, 1, 0);
            this.tableLayoutPanel_NewDishInpout.Controls.Add(this.comboBox_TypeDish, 1, 1);
            this.tableLayoutPanel_NewDishInpout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_NewDishInpout.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_NewDishInpout.Name = "tableLayoutPanel_NewDishInpout";
            this.tableLayoutPanel_NewDishInpout.RowCount = 3;
            this.tableLayoutPanel_NewDishInpout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_NewDishInpout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_NewDishInpout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_NewDishInpout.Size = new System.Drawing.Size(388, 159);
            this.tableLayoutPanel_NewDishInpout.TabIndex = 2;
            // 
            // textBox_PopularityDish
            // 
            this.textBox_PopularityDish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_PopularityDish.Enabled = false;
            this.textBox_PopularityDish.Location = new System.Drawing.Point(197, 121);
            this.textBox_PopularityDish.Name = "textBox_PopularityDish";
            this.textBox_PopularityDish.PlaceholderText = "xx";
            this.textBox_PopularityDish.Size = new System.Drawing.Size(188, 23);
            this.textBox_PopularityDish.TabIndex = 5;
            this.textBox_PopularityDish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_NameDish
            // 
            this.label_NameDish.AutoSize = true;
            this.label_NameDish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_NameDish.Font = new System.Drawing.Font("Gotham", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_NameDish.Location = new System.Drawing.Point(3, 0);
            this.label_NameDish.Name = "label_NameDish";
            this.label_NameDish.Size = new System.Drawing.Size(188, 53);
            this.label_NameDish.TabIndex = 0;
            this.label_NameDish.Text = "Nom du plat : ";
            this.label_NameDish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_TypeOfDish
            // 
            this.label_TypeOfDish.AutoSize = true;
            this.label_TypeOfDish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TypeOfDish.Font = new System.Drawing.Font("Gotham", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_TypeOfDish.Location = new System.Drawing.Point(3, 53);
            this.label_TypeOfDish.Name = "label_TypeOfDish";
            this.label_TypeOfDish.Size = new System.Drawing.Size(188, 53);
            this.label_TypeOfDish.TabIndex = 1;
            this.label_TypeOfDish.Text = "Type de plat :";
            this.label_TypeOfDish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_PopularityDish
            // 
            this.label_PopularityDish.AutoSize = true;
            this.label_PopularityDish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_PopularityDish.Font = new System.Drawing.Font("Gotham", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_PopularityDish.Location = new System.Drawing.Point(3, 106);
            this.label_PopularityDish.Name = "label_PopularityDish";
            this.label_PopularityDish.Size = new System.Drawing.Size(188, 53);
            this.label_PopularityDish.TabIndex = 2;
            this.label_PopularityDish.Text = "Popularité du plat :";
            this.label_PopularityDish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_NameDish
            // 
            this.textBox_NameDish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_NameDish.Location = new System.Drawing.Point(197, 15);
            this.textBox_NameDish.Name = "textBox_NameDish";
            this.textBox_NameDish.Size = new System.Drawing.Size(188, 23);
            this.textBox_NameDish.TabIndex = 3;
            this.textBox_NameDish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox_TypeDish
            // 
            this.comboBox_TypeDish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_TypeDish.AutoCompleteCustomSource.AddRange(new string[] {
            "Entrée",
            "Plat",
            "Dessert"});
            this.comboBox_TypeDish.FormattingEnabled = true;
            this.comboBox_TypeDish.Items.AddRange(new object[] {
            "Entrée",
            "Plat",
            "Dessert"});
            this.comboBox_TypeDish.Location = new System.Drawing.Point(197, 68);
            this.comboBox_TypeDish.Name = "comboBox_TypeDish";
            this.comboBox_TypeDish.Size = new System.Drawing.Size(188, 23);
            this.comboBox_TypeDish.TabIndex = 4;
            // 
            // dataGridView_DishComposedBy
            // 
            this.dataGridView_DishComposedBy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DishComposedBy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DishComposedBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_DishComposedBy.Location = new System.Drawing.Point(3, 168);
            this.dataGridView_DishComposedBy.Name = "dataGridView_DishComposedBy";
            this.dataGridView_DishComposedBy.RowHeadersVisible = false;
            this.dataGridView_DishComposedBy.RowTemplate.Height = 25;
            this.dataGridView_DishComposedBy.Size = new System.Drawing.Size(388, 159);
            this.dataGridView_DishComposedBy.TabIndex = 3;
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
            this.tableLayoutPanel_background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ingredients)).EndInit();
            this.tableLayoutPanel_IngredientPannel.ResumeLayout(false);
            this.tableLayoutPanel_newDish.ResumeLayout(false);
            this.tableLayoutPanel_NewDishInpout.ResumeLayout(false);
            this.tableLayoutPanel_NewDishInpout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DishComposedBy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_background;
        private System.Windows.Forms.DataGridView dataGridView_ingredients;
        private TableLayoutPanel tableLayoutPanel_IngredientPannel;
        private Button button_createIngredient;
        private Label label_Title;
        private TableLayoutPanel tableLayoutPanel_newDish;
        private Button button_ConfirmDish;
        private Button button_CancelDish;
        private TableLayoutPanel tableLayoutPanel_NewDishInpout;
        private Label label_NameDish;
        private Label label_TypeOfDish;
        private Label label_PopularityDish;
        private TextBox textBox_NameDish;
        private ComboBox comboBox_TypeDish;
        private TextBox textBox_PopularityDish;
        private DataGridView dataGridView_DishComposedBy;
        private DataGridViewButtonColumn btn_AddIngredients;
    }
}