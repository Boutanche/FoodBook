
namespace ClientDesktop.Composants
{
    partial class DayServiceControlComponent
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
            this.tlp_DayAndService = new System.Windows.Forms.TableLayoutPanel();
            this.dishServiceControlComponent_Dessert = new ClientDesktop.Composants.DishServiceControlComponent();
            this.dishServiceControlComponent_Starter = new ClientDesktop.Composants.DishServiceControlComponent();
            this.dishServiceControlComponent_Dish = new ClientDesktop.Composants.DishServiceControlComponent();
            this.tlp_DayAndService.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_DayAndService
            // 
            this.tlp_DayAndService.ColumnCount = 1;
            this.tlp_DayAndService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_DayAndService.Controls.Add(this.dishServiceControlComponent_Dessert, 0, 2);
            this.tlp_DayAndService.Controls.Add(this.dishServiceControlComponent_Starter, 0, 0);
            this.tlp_DayAndService.Controls.Add(this.dishServiceControlComponent_Dish, 0, 1);
            this.tlp_DayAndService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_DayAndService.Location = new System.Drawing.Point(0, 0);
            this.tlp_DayAndService.Name = "tlp_DayAndService";
            this.tlp_DayAndService.RowCount = 3;
            this.tlp_DayAndService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_DayAndService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_DayAndService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_DayAndService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_DayAndService.Size = new System.Drawing.Size(393, 591);
            this.tlp_DayAndService.TabIndex = 0;
            // 
            // dishServiceControlComponent_Dessert
            // 
            this.dishServiceControlComponent_Dessert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dishServiceControlComponent_Dessert.Location = new System.Drawing.Point(3, 395);
            this.dishServiceControlComponent_Dessert.Name = "dishServiceControlComponent_Dessert";
            this.dishServiceControlComponent_Dessert.Size = new System.Drawing.Size(387, 193);
            this.dishServiceControlComponent_Dessert.TabIndex = 2;
            // 
            // dishServiceControlComponent_Starter
            // 
            this.dishServiceControlComponent_Starter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dishServiceControlComponent_Starter.Location = new System.Drawing.Point(3, 3);
            this.dishServiceControlComponent_Starter.Name = "dishServiceControlComponent_Starter";
            this.dishServiceControlComponent_Starter.Size = new System.Drawing.Size(387, 190);
            this.dishServiceControlComponent_Starter.TabIndex = 0;
            // 
            // dishServiceControlComponent_Dish
            // 
            this.dishServiceControlComponent_Dish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dishServiceControlComponent_Dish.Location = new System.Drawing.Point(3, 199);
            this.dishServiceControlComponent_Dish.Name = "dishServiceControlComponent_Dish";
            this.dishServiceControlComponent_Dish.Size = new System.Drawing.Size(387, 190);
            this.dishServiceControlComponent_Dish.TabIndex = 3;
            // 
            // DayServiceControlComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_DayAndService);
            this.Name = "DayServiceControlComponent";
            this.Size = new System.Drawing.Size(393, 591);
            this.tlp_DayAndService.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_DayAndService;
        private DishServiceControlComponent dishServiceControlComponent_Starter;
        private DishServiceControlComponent dishServiceControlComponent_Dessert;
        private DishServiceControlComponent dishServiceControlComponent_Dish;
    }
}
